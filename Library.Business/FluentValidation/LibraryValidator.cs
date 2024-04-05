using FluentValidation;
using Library.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.FluentValidation
{
    public class LibraryValidator:AbstractValidator<Libraries>
    {
        public LibraryValidator() {
            RuleFor(p=>p.Name).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(3);
            RuleFor(p=>p.Author).NotEmpty();
            RuleFor(p => p.Author).NotEmpty();
            RuleFor(p => p.Author).MinimumLength(2);
            RuleFor(p=>p.CompletedPages).GreaterThanOrEqualTo(0);
            RuleFor(p=>p.TotalOfPages).NotEmpty().GreaterThanOrEqualTo(p=>p.CompletedPages)
            .WithMessage("Total of pages is more than or equal to completed pages.").GreaterThan(0);
            RuleFor(p=>p.Category).NotEmpty();
            
        }

    }
    public class BookShopListValidator : AbstractValidator<BookShopList>
    {
        public BookShopListValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(3);
            RuleFor(p => p.Author).NotEmpty();
            RuleFor(p => p.Author).MinimumLength(2);
            RuleFor(p => p.Price).NotEmpty().GreaterThan(0);
            RuleFor(p => p.Category).NotEmpty();

        }

    }

    public class PlannedBooksValidator : AbstractValidator<UserReadingPlan>
    {
        public PlannedBooksValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(3);
            RuleFor(p => p.Author).NotEmpty();
            RuleFor(p => p.CompletedPages).GreaterThanOrEqualTo(0);
            RuleFor(p => p.TotalOfPages).NotEmpty().GreaterThanOrEqualTo(p => p.CompletedPages)
                .WithMessage("Total of pages is more than or equal to completed pages.").GreaterThan(0);
            RuleFor(p => p.Category).NotEmpty();
        }
    }
     
}
