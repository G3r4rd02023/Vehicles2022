using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles2022.Data.Entities;
using Vehicles2022.Models;

namespace Vehicles2022.Helpers
{
    public interface IConverterHelper
    {
        Task<User> ToUserAsync(UserViewModel model, string path, bool isNew);

        UserViewModel ToUserViewModel(User user);

        Task<Vehicle> ToVehicleAsync(VehicleViewModel model, bool isNew);

        VehicleViewModel ToVehicleViewModel(Vehicle vehicle);

        Task<Detail> ToDetailAsync(DetailViewModel model, bool isNew);

        DetailViewModel ToDetailViewModel(Detail detail);
    }
}
