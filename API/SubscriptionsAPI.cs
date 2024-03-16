using GoogleRareBe.Models;
using Microsoft.EntityFrameworkCore;

namespace GoogleRareBe.API
{
    public static class SubscriptionsAPI
    {
        public static void Map(WebApplication app)
        {
            app.MapPost("/api/addSubscriptions", (GoogleRareBeDbContext db, Subscription subscription) =>
            {
                db.Subscriptions.Add(subscription);
                db.SaveChanges();
                return Results.Created($"/api/subscriptions/{subscription.Id}", subscription);
            });



        }
    }

}
