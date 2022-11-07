using My_book_store.Data.Model;

namespace My_book_store.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            //scope with application service
            using (var ServiceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //get db
                var context = ServiceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Books()
                    {
                        Title = "First Books",
                        Description = "First Description",
                        CoverUrl = "Https...",
                        DatedAdded = DateTime.Now.AddDays(-5),
                        DateRead = DateTime.Now,
                        Genre="comdy",
                        IsRead=true,
                        Rate=6
                    },
                    new Books()
                    {
                        Title = "Second Books",
                        Description = "Second Description",
                        CoverUrl = "Https...",
                        DatedAdded = DateTime.Now.AddDays(-5),
                        Genre = "comdy",
                        IsRead = false,
                        Rate = 6
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
