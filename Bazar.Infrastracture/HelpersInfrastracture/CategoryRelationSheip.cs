using Bazar.Domain.Entitis;
using Microsoft.EntityFrameworkCore;

namespace Bazar.Infrastracture.HelpersInfrastracture
{
    internal static class CategoryRelationSheip 
    {
        /// <summary>
        /// Configures one-to-many relationships between the Category entity and multiple related entities.
        /// Uses the generic helper method RelationShipOne_To_Many to map each entity with its corresponding foreign key and navigation properties.
        /// This method centralizes the setup of Category-related relationships for entities such as Books, Animals, Electronics, Furniture, Kitchen, Sports, and Advertisements.
        /// </summary>
        /// <param name="modelBuilder">The ModelBuilder instance used to configure entity relationships in EF Core.</param>
        public static void CategoryRelationSheipToMany(ModelBuilder modelBuilder)
        {
            HelpersRelationShip.RelationShipOne_To_Many<Books, Category>(modelBuilder,
                b => b.Category,
                c => c.Books,
                nameof(Books.CategoryId)
                );
            HelpersRelationShip.RelationShipOne_To_Many<Animals, Category>(modelBuilder,
                a => a.Category,
                c => c.Animals,
                nameof(Animals.CategoryId)
                );
            HelpersRelationShip.RelationShipOne_To_Many<Electronics, Category>(modelBuilder,
                e => e.Category,
                c => c.Electronics,
                nameof(Electronics.CategoryId)
                );
            HelpersRelationShip.RelationShipOne_To_Many<Furniture, Category>(modelBuilder,
                f => f.Category,
                c => c.Furnitures,
                nameof(Furniture.CategoryId)
                );
            HelpersRelationShip.RelationShipOne_To_Many<Kitchen, Category>(modelBuilder,
                k => k.Category,
                c => c.Kitchens,
                nameof(Kitchen.CategoryId)
                );
            HelpersRelationShip.RelationShipOne_To_Many<Sports, Category>(modelBuilder,
                s => s.Category,
                c => c.Sports,
                nameof(Sports.CategoryId)
                );
            HelpersRelationShip.RelationShipOne_To_Many<Advertisements, Category>(modelBuilder,
                a => a.Category,
                c => c.Advertisements,
                nameof(Advertisements.CategoryId)
                );
        }
    }
}
