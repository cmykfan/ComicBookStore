using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ComicBookStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
       //This is where I add my products below.   Look into how to add pictures later on.  Add some more funny comic book stuff later.
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Lightsaber",
                        Description = "What every Jedi needs. Color: SkyWalker Blue. Note: The Force not included.",
                        Category = "Star Wars",
                        Price = 30
                    },
                    new Product
                    {
                        Name = "Blaster",
                        Description = "Want to be a good smuggler? Gotta have a blaster.",
                        Category = "Star Wars",
                        Price = 18
                    },
                    new Product
                    {
                        Name = "Green Lantern Power Ring",
                        Description = "Just the thing to defeat evil, well unless it's yellow.",
                        Category = "DC",
                        Price = 23
                    },
                    new Product
                    {
                        Name = "BatMan Utility Belt",
                        Description = "What a great way to keep all your stuff! Bat stuff not included.",
                        Category = "DC",
                        Price = 19
                    },
                    new Product
                    {
                        Name = "Magic Golden Lasso",
                        Description = "Ladies, come on! The power make men tell the truth. You know it!",
                        Category = "DC",
                        Price = 100
                    },
                    new Product
                    {
                        Name = "Mjolnir",
                        Description = "Want to be Thor, God of Thunder? Well now you can! Warning: Not responsible for spontaineous Storms or accidentally turning you into your alter ego Dr. Blake.",
                        Category = "Marvel",
                        Price = 22
                    },
                    new Product
                    {
                        Name = "Infinity Gauntlet",
                        Description = "Be the envy of every galaxy dictator. Note: Infinity Gems not included.",
                        Category = "Marvel",
                        Price = 25
                    },
                    new Product
                    {
                        Name = "Jack Kirby Cigar",
                        Description = "What every tough guy comic book artist needs. Get yourself a genuine Jack Kirby stoogie and create some characters that will last!",
                        Category = "Marvel",
                        Price = 3
                    },
                    new Product
                    {
                        Name = "Web Fluid",
                        Description = "We have a lot of the stuff left over from the last Spider-Man movie. Sorry, no web shooters.",
                        Category = "Marvel",
                        Price = 29
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
