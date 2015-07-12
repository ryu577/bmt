using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using talker.Models;
using System.Web.ModelBinding;

namespace talker
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string uname = HttpContext.Current.User.Identity.Name;
            DataContext _db = new DataContext();
            

        }
        
        public IQueryable<LiveBid> GetCategoryBids([QueryString("catid")] int? categoryId)
        {
            var _db = new talker.Models.DataContext();
            IQueryable<LiveBid> query = _db.LiveBids;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }
    }
}