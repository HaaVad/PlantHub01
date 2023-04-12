﻿using Microsoft.EntityFrameworkCore;
using UserContext.Data;
using PlantHub01.Models;


namespace NerdHub.Models
{

    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PlantHub01Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PlantHub01Context>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                    new User
                    {
                        Name = "William",
                        Bio = "Digger planter og pupper",
                        Location = "Oslo",

                    },

                    new User
                    {
                        Name = "Henrik",
                        Bio = "Keen på  dyrke marihuana med meg???",
                        Location = "Oslo"
                    },

                    new User
                    {
                        Name = "Adam",
                        Bio = "Need to get my palm tree watered on a weekly basis",
                        Location = "Bergen",
                        Picture = "https://assets.cdn.moviepilot.de/files/7bf197667b87af6fd5c8c516a9e85fa27a7227349fe7d803695c221ec722/limit/1440/863/MV5BMjA5NjZhOTYtOTgwMS00ZmM0LWE4MzAtNTNlNzA0MGJjZTBjXkEyXkFqcGdeQXVyMTI5NjYwNDQ%40._V1_SY1000_CR0%2C0%2C1668%2C1000_AL_.jpg",

                    },

                    new User
                    {
                        Name = "Jeppe",
                        Bio = "Bytter stiklinger mot vanning",
                        Location = "Oslo"
                    },

                    new User
                    {
                        Name = "Bella Delfi",
                        Bio = "Hiee, my name is Bella, and I'm an ESFJ, Libra, plantmommy and knitlover! I recently went through a break-up, and though it was sad I am now ready to mingle with all you other plant people and expand my collection.\r\n",
                        Location = "Oslo",
                        Picture = "https://assets.cdn.moviepilot.de/files/7bf197667b87af6fd5c8c516a9e85fa27a7227349fe7d803695c221ec722/limit/1440/863/MV5BMjA5NjZhOTYtOTgwMS00ZmM0LWE4MzAtNTNlNzA0MGJjZTBjXkEyXkFqcGdeQXVyMTI5NjYwNDQ%40._V1_SY1000_CR0%2C0%2C1668%2C1000_AL_.jpg",

                    }



                );
                context.SaveChanges();

                context.Plant.AddRange(
                    new Plant
                    {
                        UserId = 1,
                        Name = "Alistar",
                        About = "Got this from my mum. Grows fast, so plenty of cuttings to share!",
                        PlantFamily = "Araceae",
                        PlantName = "Monstera",
                        Image = "https://i.pinimg.com/originals/3e/a7/45/3ea74524751a43f2a06356bde34d2e5d.jpg"

                    },

                    new Plant
                    {
                        UserId = 1,
                        Name = "Jhin",
                        About = "Got this from my mum. Grows fast, so plenty of cuttings to share!",
                        PlantFamily = "Araceae",
                        PlantName = "Monstera",
                        Image = "https://i.pinimg.com/originals/3e/a7/45/3ea74524751a43f2a06356bde34d2e5d.jpg"

                    },
                    new Plant
                    {
                        UserId = 2,
                        Name = "Yumi",
                        About = "Got this from my mum. Grows fast, so plenty of cuttings to share!",
                        PlantFamily = "Araceae",
                        PlantName = "Monstera",
                        Image = "https://i.pinimg.com/originals/3e/a7/45/3ea74524751a43f2a06356bde34d2e5d.jpg"

                    },
                    new Plant
                    {
                        UserId = 1,
                        Name = "Zoe",
                        About = "Got this from my mum. Grows fast, so plenty of cuttings to share!",
                        PlantFamily = "Araceae",
                        PlantName = "Gullranke",
                        Image = "https://tise-static.telenorcdn.net/5f26f426af9bb3003190f1ba/image0/e3a38da1-8569-4bb2-b3e8-9d6091734f28/gullranke"

                    },
                    new Plant
                    {
                        UserId = 2,
                        Name = "Pyke",
                        About = "Got this from my mum. Grows fast, so plenty of cuttings to share!",
                        PlantFamily = "Araceae",
                        PlantName = "Gullranke",
                        Image = "https://tise-static.telenorcdn.net/5f26f426af9bb3003190f1ba/image0/e3a38da1-8569-4bb2-b3e8-9d6091734f28/gullranke"

                    },
                    new Plant
                    {
                        UserId = 3,
                        Name = "Lux",
                        About = "Got this from my mum. Grows fast, so plenty of cuttings to share!",
                        PlantFamily = "Araceae",
                        PlantName = "Gullranke",
                        Image = "https://tise-static.telenorcdn.net/5f26f426af9bb3003190f1ba/image0/e3a38da1-8569-4bb2-b3e8-9d6091734f28/gullranke"

                    },


                    new Plant
                    {
                        UserId = 3,
                        Name = "Samira",
                        About = "Got this from my mum. Grows fast, so plenty of cuttings to share!",
                        PlantFamily = "Araceae",
                        PlantName = "Gullranke",
                        Image = "https://tise-static.telenorcdn.net/5f26f426af9bb3003190f1ba/image0/e3a38da1-8569-4bb2-b3e8-9d6091734f28/gullranke"

                    },
                    new Plant
                    {
                        UserId = 4,
                        Name = "Ekko",
                        About = "Got this from my mum. Grows fast, so plenty of cuttings to share!",
                        PlantFamily = "Araceae",
                        PlantName = "Gullranke",
                        Image = "https://tise-static.telenorcdn.net/5f26f426af9bb3003190f1ba/image0/e3a38da1-8569-4bb2-b3e8-9d6091734f28/gullranke"

                    },
                    new Plant
                    {
                        UserId = 3,
                        Name = "Nunu",
                        About = "Got this from my mum. Grows fast, so plenty of cuttings to share!",
                        PlantFamily = "Araceae",
                        PlantName = "Gullranke",
                        Image = "https://tise-static.telenorcdn.net/5f26f426af9bb3003190f1ba/image0/e3a38da1-8569-4bb2-b3e8-9d6091734f28/gullranke"

                    },

                    new Plant
                    {
                        UserId = 4,
                        Name = "Vi",
                        About = "Got this from my mum. Grows fast, so plenty of cuttings to share!",
                        PlantFamily = "Araceae",
                        PlantName = "Gullranke",
                        Image = "https://tise-static.telenorcdn.net/5f26f426af9bb3003190f1ba/image0/e3a38da1-8569-4bb2-b3e8-9d6091734f28/gullranke"

                    },
                    new Plant
                    {
                        UserId = 4,
                        Name = "Ashe",
                        About = "Got this from my mum. Grows fast, so plenty of cuttings to share!",
                        PlantFamily = "Araceae",
                        PlantName = "Gullranke",
                        Image = "https://tise-static.telenorcdn.net/5f26f426af9bb3003190f1ba/image0/e3a38da1-8569-4bb2-b3e8-9d6091734f28/gullranke"

                    }, 
                    
                    new Plant
                    {
                        UserId = 5,
                        Name = "Jinx",
                        About = "Got this from my mum. Grows fast, so plenty of cuttings to share!",
                        PlantFamily = "Araceae",
                        PlantName = "Gullranke",
                        Image = "https://tise-static.telenorcdn.net/5f26f426af9bb3003190f1ba/image0/e3a38da1-8569-4bb2-b3e8-9d6091734f28/gullranke"

                    },

                    new Plant
                    {
                        UserId = 5,
                        Name = "Seraphine",
                        About = "My lovely!!",
                        PlantFamily = "Araceae",
                        PlantName = "Gullranke",
                        Image = "https://tise-static.telenorcdn.net/5f26f426af9bb3003190f1ba/image0/e3a38da1-8569-4bb2-b3e8-9d6091734f28/gullranke"

                    },
                    new Plant
                    {
                        UserId = 5,
                        Name = "Garren",
                        About = "Got this from my mum. Grows fast, so plenty of cuttings to share!",
                        PlantFamily = "Araceae",
                        PlantName = "Gullranke",
                        Image = "https://tise-static.telenorcdn.net/5f26f426af9bb3003190f1ba/image0/e3a38da1-8569-4bb2-b3e8-9d6091734f28/gullranke"

                    },
                    new Plant
                    {
                        UserId = 5,
                        Name = "Veigar",
                        About = "Got this from my mum. Grows fast, so plenty of cuttings to share!",
                        PlantFamily = "Araceae",
                        PlantName = "Gullranke",
                        Image = "https://tise-static.telenorcdn.net/5f26f426af9bb3003190f1ba/image0/e3a38da1-8569-4bb2-b3e8-9d6091734f28/gullranke"

                    }

                    );  


            }
        }
    }

}