using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tarker.Booking.Domain.Entities.Customer;

namespace Tarker.Booking.Persistence.Configuration
{
    public class CustomerConfiguration
    {
        public CustomerConfiguration(EntityTypeBuilder<CustomerEntity> entityBuilder)
        {
            entityBuilder.HasKey(x => x.CustomerId);
            entityBuilder.Property(x => x.FullName).IsRequired();
            entityBuilder.Property(x => x.DocumentNumber).IsRequired();
        }
    }
}
