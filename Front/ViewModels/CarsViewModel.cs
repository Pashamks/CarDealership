
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
        private Car _currentItem;

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
            var json = client.GetStringAsync("https://localhost:5001/api/Cars").Result;
            var list = JsonConvert.DeserializeObject<List<Car>>(json);
            Cars = new ObservableCollection<Car>(list);
        }
        public ObservableCollection<Car> Cars
        {
            get { return _cars; }
            set { _cars = value; }
        }
        public Car CurrentItem
        {
            get { return _currentItem; }
            set { _currentItem = value; }
        }
        public ICommand SellItem
        {
            get
            {
                _sellCar ??= new CommandBase(_ => DeleteItemMethod());
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
        private void DeleteItemMethod()
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = JsonContent.Create(CurrentItem),
                Method = HttpMethod.Delete,
                RequestUri = new Uri("https://localhost:5001/api/Goods")
            };
            client.SendAsync(request).Wait();

            LoadItems();
        }
        private void AddItemMethod()
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = JsonContent.Create(CurrentItem),
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:5001/api/Goods")
            };
            client.SendAsync(request).Wait();
        }
        private void UpdateItemMethod()
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = JsonContent.Create(CurrentItem),
                Method = HttpMethod.Put,
                RequestUri = new Uri("https://localhost:5001/api/Goods")
            };
            client.SendAsync(request).Wait();
        }
    }
}
