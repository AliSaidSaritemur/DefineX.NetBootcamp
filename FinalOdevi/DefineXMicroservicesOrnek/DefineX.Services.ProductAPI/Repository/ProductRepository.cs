using AutoMapper;
using DefineX.Services.ProductAPI.dbcontexts;
using DefineX.Services.ProductAPI.dto;
using DefineX.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace DefineX.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        //Constructor Injection 
        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            Product product = _mapper.Map<ProductDto, Product>(productDto);
            //gelen ProductDto nun içindeki ProductId 0 dan büyük ise güncelleme yapılacak
            if (product.id > 0)
            {
                _db.Products.Update(product);
            }
            else
            {
                //0 dan böyük değilse yeni bir kayıt eklenecek

                _db.Products.Add(product);
            }
            await _db.SaveChangesAsync();
            //kayıt eklendikten sonra databaseden eklenen product objesi geriye produtcDto olarak döndürülür
            return _mapper.Map<Product, ProductDto>(product);
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            try
            {
                Product product = await _db.Products.FirstOrDefaultAsync(u => u.id == productId);
                if (product == null)
                {
                    return false;
                }
                _db.Products.Remove(product); //delete from Product where Id=productId
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<ProductDto> GetProductById(int productId)
        {
            //linq select * from Product where Id=productId
            //{Id:1,Name : Product1}
            ProductDto productDto = await _db.Products
        .Where(p => p.id == productId)
        .Select(p => new ProductDto
        {
            id = p.id,
            Tittle = p.Tittle,
            Description = p.Description,
            Type = p.Type,
            Brand = p.Brand,
            CategoryName = p.CategoryName,
            Collection = p.Collection,
            Price = p.Price,
            Tags = p.tags,
            IsHot = p.IsHot,
            Discount = p.discount,
            IsNew = p.IsNew,
            Variants = _db.Variants.Where(v => v.id == p.id).ToArray(),
            Images = _db.Images.Where(i => i.id == p.id).ToArray()
        })
        .FirstOrDefaultAsync();

            return _mapper.Map<ProductDto>(productDto);
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            List<ProductDto> productDtoList = await _db.Products
            .Select(p => new ProductDto
            {
                id = p.id,
                Tittle = p.Tittle,
                Description = p.Description,
                Type = p.Type,
                Brand = p.Brand,
                CategoryName = p.CategoryName,
                Collection = p.Collection,
                Price = p.Price,
                Tags = p.tags,
                IsHot = p.IsHot,
                Discount = p.discount,
                IsNew = p.IsNew,
                Variants = _db.Variants.Where(v => v.id == p.id).ToArray(),
                Images = _db.Images.Where(i => i.id == p.id).ToArray()
            }).ToListAsync();
            return _mapper.Map<List<ProductDto>>(productDtoList);
        }
    }
}
