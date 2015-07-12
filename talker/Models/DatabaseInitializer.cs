using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace talker.Models
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            GetDiscussions().ForEach(c => context.Discussions.Add(c));
            GetLiveBids().ForEach(p => context.LiveBids.Add(p));
            GetCategories().ForEach(c => context.Categories.Add(c));
        }

        private static List<Discussion> GetDiscussions()
        {
            var discussions = new List<Discussion> {
                new Discussion
                {
                    DiscussionID = 1,
                    ProvidingUserName = "ryu576",
                    ReceivingUserName = "rohitpandey@gmail.com",
                    DiscussionStartTime = DateTime.Parse("2/21/2009 10:35 PM"),
                    DiscussionEndTime = DateTime.Parse("2/21/2009 10:38 PM"),
                    TransactionAmount = 0.1,
                    Status = "Future",
                    Rating = 0
                },
                new Discussion
                {
                    DiscussionID = 1,
                    ProvidingUserName = "ryu576",
                    ReceivingUserName = "rohitpandey@gmail.com",
                    DiscussionStartTime = DateTime.Parse("2/21/2009 10:35 PM"),
                    DiscussionEndTime = DateTime.Parse("2/21/2009 10:38 PM"),
                    TransactionAmount = 0.1,
                    Status = "Future",
                    Rating = 0
                },
                new Discussion
                {
                    DiscussionID = 1,
                    ProvidingUserName = "ryu576",
                    ReceivingUserName = "rohitpandey@gmail.com",
                    DiscussionStartTime = DateTime.Parse("2/21/2009 10:35 PM"),
                    DiscussionEndTime = DateTime.Parse("2/21/2009 10:38 PM"),
                    TransactionAmount = 0.1,
                    Status = "Future",
                    Rating = 0
                },
                new Discussion
                {
                    DiscussionID = 1,
                    ProvidingUserName = "ryu576",
                    ReceivingUserName = "rohitpandey@gmail.com",
                    DiscussionStartTime = DateTime.Parse("2/21/2009 10:35 PM"),
                    DiscussionEndTime = DateTime.Parse("2/21/2009 10:38 PM"),
                    TransactionAmount = 0.1,
                    Status = "Future",
                    Rating = 0
                },
                new Discussion
                {
                    DiscussionID = 1,
                    ProvidingUserName = "ryu576",
                    ReceivingUserName = "rohitpandey@gmail.com",
                    DiscussionStartTime = DateTime.Parse("2/21/2009 10:35 PM"),
                    DiscussionEndTime = DateTime.Parse("2/21/2009 10:38 PM"),
                    TransactionAmount = 0.1,
                    Status = "Future",
                    Rating = 0
                },
            };

            return discussions;
        }

        private static List<LiveBid> GetLiveBids()
        {
            var liveBids = new List<LiveBid> {
                new LiveBid
                {
                    BidID = 1,
                    ProvidingUserName = "ryu576",
                    AvailableStartTime = DateTime.Parse("2/21/2009 10:35 PM"),
                    AvailableEndTime = DateTime.Parse("2/21/2009 10:38 PM"),
                    DesiredBidPrice = 1.1,
                    Status = false,
                    CategoryID = 1
               },
                new LiveBid 
                {
                    BidID = 2,
                    ProvidingUserName = "ryu576",
                    AvailableStartTime = DateTime.Parse("2/21/2009 10:35 PM"),
                    AvailableEndTime = DateTime.Parse("2/21/2009 10:38 PM"),
                    DesiredBidPrice = 1.1,
                    Status = true,
                    CategoryID = 2
               },
                new LiveBid
                {
                    BidID = 3,
                    ProvidingUserName = "ryu576",
                    AvailableStartTime = DateTime.Parse("2/21/2009 10:35 PM"),
                    AvailableEndTime = DateTime.Parse("2/21/2009 10:38 PM"),
                    DesiredBidPrice = 1.1,
                    Status = true
                },
            };

            return liveBids;
        }

        private static List<Category> GetCategories()
        {
            var Categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Physics",
                    Description = "Physics "
               },
                new Category 
                {
                    CategoryID = 2,
                    CategoryName = "Chemistry",
                    Description = "Chemistry"
               },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Math",
                    Description = "Math"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Legal",
                    Description = "Legal"
                }
            };

            return Categories;
        }
    }
}