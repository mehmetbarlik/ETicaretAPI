using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("Lütfen ürün adını boş geçmeyin.")
                .NotNull()
                .WithMessage("Lütfen ürün adını boş geçmeyin.")
                .MaximumLength(150)
                .MinimumLength(3)
                .WithMessage("Lütfen ürün adını 3 ile 150 karakter arasında girin");

            RuleFor(p => p.Stock)
                .NotEmpty()
                .WithMessage("Lütfen stok bilgisini boş geçmeyin.")
                .NotNull()
                .WithMessage("Lütfen stok bilgisini boş geçmeyin.")
                .Must(s => s >= 0)
                .WithMessage("Stok bilgisi sıfırdan küçük olamaz.");

            RuleFor(p => p.Price)
                .NotEmpty()
                .WithMessage("Lütfen fiyat bilgisini boş geçmeyin.")
                .NotNull()
                .WithMessage("Lütfen fiyat bilgisini boş geçmeyin.")
                .Must(p => p >= 0)
                .WithMessage("Fiyat bilgisi sıfırdan küçük olamaz.");

        }
    }
}
