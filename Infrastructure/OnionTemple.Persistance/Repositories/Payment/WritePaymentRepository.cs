using OnionTemplateEx.Application.Dtos;
using OnionTemplateEx.Application.Interfaces.Repositories.Payment;
using OnionTemplateEx.Domain.Entities;
using OnionTemplateEx.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Persistance.Repositories.Payment
{
    public class WritePaymentRepository : WriteRepository<PaymentEntity>, IWritePaymentRepository
    {
        public WritePaymentRepository(OnionTemplateExDbContext dbContext) : base(dbContext)
        {
        }
    }
}
