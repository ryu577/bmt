using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using talker.Models;

namespace talker
{
    public partial class PlaceBid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<LiveBid> GetLiveBid(
                        [QueryString("LiveBidId")] int? LiveBidId)
        {
            var _db = new talker.Models.DataContext();
            IQueryable<LiveBid> query = _db.LiveBids;
            if (LiveBidId.HasValue && LiveBidId > 0)
            {
                query = query.Where(p => p.BidID == LiveBidId);
            }
            else
            {
                query = null;
            }
            return query;
        }
        
        protected void productDetail_PageIndexChanging(object sender, EventArgs e) {
        
        }
        protected void PlaceBid_Click(object sender, EventArgs e) {
            DataContext _db = new DataContext();
            string RawId = Request.QueryString["LiveBidId"];
            int OriginatingBidId = Convert.ToInt32(RawId);
            PlacedBid placedBid = new PlacedBid
            {
                ReceivingMemberId = HttpContext.Current.User.Identity.Name,
                ProvidingMemberId = _db.LiveBids.SingleOrDefault(p => p.BidID == OriginatingBidId).ProvidingUserName,
                BidId = OriginatingBidId,
                BidTime = DateTime.Now
            };
            _db.PlacedBids.Add(placedBid);
            _db.SaveChanges();
            Response.Redirect("LiveBids.aspx");
        }
    }
}