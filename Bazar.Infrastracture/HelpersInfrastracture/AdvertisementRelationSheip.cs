using Bazar.Domain.Entitis;
using Microsoft.EntityFrameworkCore;

namespace Bazar.Infrastracture.HelpersInfrastracture
{
    internal static class AdvertisementRelationSheip 
    {
        /// <summary>
        /// Configures one-to-many relationships between the Advertisements entity and multiple related entities.
        /// Utilizes the generic helper method RelationShipOne_To_Many to establish mappings between Advertisements and entities such as Books, Animals, Electronics, Furniture, Kitchen, and Sports.
        /// This centralizes Advertisement-related relationship configurations for easier maintenance and consistency in the EF Core model.
        /// </summary>
        /// <param name="modelBuilder">The ModelBuilder instance used to define entity relationships within EF Core.</param>
        public static void AdvertisementRelationSheipToMany(ModelBuilder modelBuilder)
        {
            HelpersRelationShip.RelationShipOne_To_Many<Books, Advertisements>(modelBuilder,
                b => b.Advertisements,
                a => a.Books,
                nameof(Books.AdvertisementsId)
                );
            HelpersRelationShip.RelationShipOne_To_Many<Animals, Advertisements>(modelBuilder,
                a => a.Advertisements,
                ad => ad.Animals,
                nameof(Animals.AdvertisementsId)
                );
            HelpersRelationShip.RelationShipOne_To_Many<Electronics, Advertisements>(modelBuilder,
                e => e.Advertisements,
                a => a.Electronics,
                nameof(Electronics.AdvertisementsId)
                );
            HelpersRelationShip.RelationShipOne_To_Many<Furniture, Advertisements>(modelBuilder,
                f => f.Advertisements,
                a => a.Furnitures,
                nameof(Furniture.AdvertisementsId)
                );
            HelpersRelationShip.RelationShipOne_To_Many<Kitchen, Advertisements>(modelBuilder,
                k => k.Advertisements,
                a => a.Kitchens,
                nameof(Kitchen.AdvertisementsId)
                );
            HelpersRelationShip.RelationShipOne_To_Many<Sports, Advertisements>(modelBuilder,
                s => s.Advertisements,
                a => a.Sports,
                nameof(Sports.AdvertisementsId)
                );
     
        }
    }
}
