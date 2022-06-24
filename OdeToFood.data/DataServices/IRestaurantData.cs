using OdeToFood.data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.data.DataServices
{

    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
