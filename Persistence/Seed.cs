using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (!context.Artists.Any())
            {
                var artists = new List<Artist>
                {
                    new Artist
                    {
                        Id= 1,
                        Name= "Trio Prime",
                        Nationality= "Ukraine",
                        Image= "./assets/flags/Ukraine.png",
                        Description= "Un numéro d'équilibre différent et exclusivement féminin. Comme dans tous les programmes de haut niveau, il faut un moment de poésie. Ici pas de muscles ni de forces mais bien des positions créatives et complexes réalisées avec grâce et élégance par trois jeunes filles Ukrainiennes. Un moment innovant de charme et de finesse au cours de ce spetacles aux multiples surprises."
                    },
                    new Artist
                    {
                        Id = 2,
                        Name= "Robi Berousek (CZ)",
                        Nationality= "République Tchèque",
                        Image= "./assets/flags/Czech.png",
                        Description= "Invité au Festival International du cirque de Monte-Carlo, cela en dit long sur la qualité de son numéro.Cet artiste confirmé présente une préstation exceptionnelle et étonnante sur plusieurs échelles... libres! La encore, l'équilibre doit être optimal... ",
                    },
                    new Artist
                    {
                        Id= 3,
                        Name= "Anton Navratil (CZ)",
                        Nationality= "République Tchèque",
                        Image= "./assets/flags/Czech.png",
                        Description= "Numéro impressionnant au trapèze Washington avec équilibres sur tête et sur chaise sur la seule 'barre' de quelques centimètres de ce même trapèze.Le tout à la coupole du chapiteau.Ce numéro demande une maitrise de l'équilibre et une concentration extrême. Il a reçu la médaille de Bronze au Festival du Cirque de Prague 2020.",
                    },
                    new Artist
                    {
                        Id= 4,
                        Name= "Catwall",
                        Nationality= "Canada",
                        Image= "./assets/flags/Canada.png",
                        Description= "Nous sommes très fiers de pouvoir vous présenter ce numéro de trampoline à 360° et qui n'a rien à voir avec les numéros de trampoline déjà vus. Cinq artistes canadiens arrivent de la prestigieuse école du Cirque de Montréal. Clown de bronze au festival de Monte - Carlo, ce numéro extraodinaire est composé d'excercices et sauts périllieux exceptionnels rattrapés au sommet d'un véritable mur de 4,5m de haut. Il faut le voir pour le croire.",
                    },
                    new Artist
                    {
                        Id= 5,
                        Name= "Orchestre (CH)",
                        Nationality= "Suisse",
                        Image= "./assets/flags/Suisse.png",
                        Description= "Passé par le festival du Cirque de Monte-Carlo, le chef d'orchestre Tino Aeby a exactement le tempérament requis pour animer un vrai spectacle de cirque de très haut niveau.",
                    },
                    new Artist
                    {
                        Id= 6,
                        Name= "Le Carrousel de Louis (CH)",
                        Nationality= "Suisse",
                        Image= "./assets/flags/Suisse.png",
                        Description= " Carrousel équestre et chevaux en liberté, cette famille Suisse s'est vue attribuer en 2019, le prix piste d'Or au festival de Massy. En 5 participations au festival International de Monte-Carlo, elle a raflé 3 clowns d'Or et 2 clowns D'argent.Dans cette discipline légendaire, il vous sera proposé un show des plus spectaculaires avec 'très rare' des chevaux qui pivotent sur eux-mêmes.",
                    },
                    new Artist
                    {
                        Id= 7,
                        Name= "Mario Berousek (CZ)",
                        Nationality= "République Tchèque",
                        Image= "./assets/flags/Czech.png",
                        Description= "Un numéro unique qui a voyagé dans le monde entier. Clown de bronze à Monaco, il s'agit du jongleur le plus rapide du monde qui figure au Guiness Book des records.La rapidité de ses mouvements et la vitesse des massues qui tourbillonnent font penser à des hélices d'avions. Numéro présenté sur la scène du Moulin Rouge à Paris pendant 5 ans.",
                    },
                    new Artist
                    {
                        Id= 8,
                        Name= "Flying Mendonca",
                        Nationality= "Brésil",
                        Image= "./assets/flags/Brésil.jpg",
                        Description= "La légendaire triple saut périlleux et double passage font partie de ce numéro de trapèze volant. Il reste un des plus spectaculaires au cirque surtout sous un grand chapiteau comme celui -ci. Cette sympathique troupe brésilienne qui parcourt le monde entier avec beaucoup de qualité est restée toute une saison au cirque d'hiver de Paris durant l'année 2017.",
                    },
                    new Artist

                    {
                        Id= 9,
                        Name= "Nicol Nicols",
                        Nationality= "Espagne",
                        Image= "./assets/flags/Espagne.jpg",
                        Description= "La légendaire triple saut périlleux et double passage font partie de ce numéro de trapèze volant. Il reste un des plus spectaculaires au cirque surtout sous un grand chapiteau comme celui - ci.Cette sympathique troupe brésilienne qui parcourt le monde entier avec beaucoup de qualité est restée toute une saison au cirque d'hiver de Paris durant l'année 2017.",
                    },
                    new Artist

                    {
                        Id= 10,
                        Name= "Jimmy l'Italien",
                        Nationality= "Italie",
                        Image= "./assets/flags/Italy.jpg",
                        Description= "Ce n'est pas dans les habitudes du concept de la Générosité, mais vous l'avez plébiscité, donc il revient avec de nouveaux numéros. Avec des sketches 'INVENTES', c'est le CLOWN chef d'orchestre avec son humour naturel, communication et garanti.Avec Jimmy on se laisse vite prendre au jeu du rire.Toute la joie, la bonne humeur et la gaité sont réunies dans les apparitions de cet artiste recoonu mondialement.",
                    },
                    new Artist
                    {
                    Id= 11,
                    Name= "Diana Boiachin (H)",
                    Nationality= "Hongrie",
                    Image= "./assets/flags/Hongrie.png",
                    Description= "Cette jeune artiste a voulu métamorphoser le numéro classique de 'mât chinois'. Le mât devient 'pôle aérien' et les figures pratiquées habituellement au sol sont ici exécutées à 12 mètres de hauteau.Un joli moment d'audace, de grâce et d'esthétisme.Ce numéro orginal est une première en France.",
                    }
                    
                };
                await context.Artists.AddRangeAsync(artists);
                await context.SaveChangesAsync();

    }
}
    }
}

 
    
    