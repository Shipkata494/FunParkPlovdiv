using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunParkPlovdiv.Data.Models;

namespace FunParkPlovdiv.Data.Configuration
{
    public class PriceEntityConfiguration : IEntityTypeConfiguration<Prices>
    {
        public void Configure(EntityTypeBuilder<Prices> builder)
        {
            builder.HasData(GetActivities());
        }
        Prices[] GetActivities()
        {
            ICollection<Prices> activities = new HashSet<Prices>();
            Prices activiti = new Prices();
            activiti = new Prices()
            {               
                Description = "MiniCourse",
                Title = "10 мин",
                Value = 25
            };
            activities.Add(activiti);
            activiti = new Prices()
            {
                Description = "BigCourse",
                Title = "15 мин",
                Value = 35
            };
            activities.Add(activiti);

            activiti = new Prices()
            {
                Description = "BirthDay",
                Title = "1 час",
                Value = 200
            };
            activities.Add(activiti);


            return activities.ToArray();
        }

    }
}
