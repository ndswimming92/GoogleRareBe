using GoogleRareBe.Models;
using Microsoft.EntityFrameworkCore;

namespace GoogleRareBe.API
{
    public static class CategoriesAPI
    {
        public static void Map(WebApplication app)
        {
            // Create Category
            app.MapPost("/api/createCategories", (GoogleRareBeDbContext db, Category newCategory) =>
            {
                db.Categories.Add(newCategory);
                db.SaveChanges();
                return Results.Created($"/api/createCategories/{newCategory.Id}", newCategory);
            });

            // Read Category
            app.MapGet("/api/readCategories", (GoogleRareBeDbContext db) =>
            {
                return db.Categories.ToList();
            });

            // Update Category
            app.MapPut("/api/updateCategories/{id}", (GoogleRareBeDbContext db, int id, Category category) =>
            {
                Category categoryToUpdate = db.Categories.SingleOrDefault(category => category.Id == id);
                if (categoryToUpdate == null)
                {
                    return Results.NotFound();
                }
                categoryToUpdate.Label = category.Label;

                db.SaveChanges();
                return Results.NoContent();
            });

            // Delete Category
            app.MapDelete("/api/deleteCategories/{id}", (GoogleRareBeDbContext db, int id) =>
            {
                Category categoryToDelete = db.Categories.SingleOrDefault(category => category.Id == id);
                if (categoryToDelete == null)
                {
                    return Results.NotFound();
                }
                db.Categories.Remove(categoryToDelete);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}
