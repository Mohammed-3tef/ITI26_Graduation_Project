using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mazeed.BLL.ViewModels;
using Mazeed.DAL.Entities;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface IRecommendationService
    {
        List<ItemVM> GetHomeRecommendations(long? userId, List<ItemVM> allItems, int count = int.MaxValue);
        List<ItemVM> GetRelatedOrBoughtTogether(long itemId, List<ItemVM> allItems, int count = 4);
    }
}
