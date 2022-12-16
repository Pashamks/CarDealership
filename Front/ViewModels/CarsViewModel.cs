
using CarDealerShip.Shared.Models;
using Front.Commands;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Input;

namespace Front.ViewModels
{
    public class CarsViewModel  : ViewModelBase
    {
        private ObservableCollection<Car> _cars;
        private ObservableCollection<Car> _solledCars;
        private ObservableCollection<Seller> _sellers;
        private Car _currentCar;
        private Seller _currentSeller;

        private ICommand _sellCar;
        private ICommand _addCar;
        private ICommand _updateCar;

        private HttpClient client = new HttpClient();
        public CarsViewModel()
        {
            LoadItems();
            AddItem = new CommandBase(_ => AddItemMethod());
        }
        private void LoadItems()
        {
            LoadCars();

            LoadSallers();

            LoadSolled();
        }
        private void LoadCars()
        {
            var jsonCars = client.GetStringAsync("https://localhost:5001/api/Cars").Result;
            var listCars = JsonConvert.DeserializeObject<List<Car>>(jsonCars);
            Cars = new ObservableCollection<Car>(listCars);
        }
        private void LoadSolled()
        {
            var jsonSoldCars = client.GetStringAsync("https://localhost:5001/api/Purchase").Result;
            var listSoldCars = JsonConvert.DeserializeObject<List<Car>>(jsonSoldCars);
            SolledCars = new ObservableCollection<Car>(listSoldCars);
        }
        private void LoadSallers()
        {
            var jsonSellers = client.GetStringAsync("https://localhost:5001/api/Seller").Result;
            var listSellers = JsonConvert.DeserializeObject<List<Seller>>(jsonSellers);
            Sellers = new ObservableCollection<Seller>(listSellers);
        }
        public ObservableCollection<Car> Cars
        {
            get { return _cars; }
            set { _cars = value; }
        }
        public ObservableCollection<Car> SolledCars
        {
            get { return _solledCars; }
            set { _solledCars = value; }
        }
        public ObservableCollection<Seller> Sellers
        {
            get { return _sellers; }
            set { _sellers = value; }
        }
        public Car CurrentCar
        {
            get { return _currentCar; }
            set { _currentCar = value; }
        }
        public Seller CurrentSeller
        {
            get { return _currentSeller; }
            set { _currentSeller = value; }
        }
        public ICommand SellItem
        {
            get
            {
                _sellCar ??= new CommandBase(_ => SelleItemMethod());
                return _sellCar;
            }
        }
        public ICommand AddItem
        {
            get
            {
                return _addCar;
            }
            set { _addCar = value; }
        }
        public ICommand UpdateItem
        {
            get
            {
                _updateCar ??= new CommandBase(_ => UpdateItemMethod());
                return _updateCar;
            }
        }
        private void SelleItemMethod()
        {
            Purchase purchase = new Purchase
            {
                BuyerName = "No Name",
                DealPrice = CurrentCar.Price,
                Seller = CurrentSeller,
                Car = CurrentCar
            };
            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = JsonContent.Create(purchase),
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:5001/api/Purchase")
            };
            client.SendAsync(request).Wait();

            LoadItems();
        }
        private void AddItemMethod()
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = JsonContent.Create(CurrentCar),
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:5001/api/Cars")
            };
            client.SendAsync(request).Wait();
        }
        private void UpdateItemMethod()
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = JsonContent.Create(CurrentCar),
                Method = HttpMethod.Put,
                RequestUri = new Uri("https://localhost:5001/api/Cars")
            };
            client.SendAsync(request).Wait();
        }
    }
}
