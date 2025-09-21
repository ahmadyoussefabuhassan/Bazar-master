using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Infrastracture.HelpersInfrastracture
{
    internal class HelpersRelationShip
    {
        /// <summary>
        /// Configures a one-to-many relationship between two entities using navigation properties and a foreign key.
        /// The entity with the "many" side is configured to have one reference to the entity on the "one" side,
        /// and the entity on the "one" side to have a collection of the "many" entities.
        /// The foreign key property in the "many" entity is specified by name.
        /// The delete behavior is set to Cascade.
        /// </summary>
        /// <typeparam name="TEntityMany">The entity type representing the "many" side.</typeparam>
        /// <typeparam name="TEntityOne">The entity type representing the "one" side.</typeparam>
        public static void RelationShipOne_To_Many<TEntityMany, TEntityOne>(
        ModelBuilder modelBuilder,
        Expression<Func<TEntityMany, TEntityOne?>> navigationToOne,
        Expression<Func<TEntityOne, IEnumerable<TEntityMany>?>> navigationToMany,
        string foreignKeyName)
        where TEntityMany : class
        where TEntityOne : class
        {
            modelBuilder.Entity<TEntityMany>()
                .HasOne(navigationToOne)
                .WithMany(navigationToMany)
                .HasForeignKey(foreignKeyName)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
