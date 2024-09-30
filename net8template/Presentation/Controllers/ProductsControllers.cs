using Microsoft.AspNetCore.Mvc;
using net8template.Domain.DTOs.Products;
using net8template.Domain.Interfaces.Application.UseCases.Products;

namespace net8template.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsControllers : ControllerBase
    {

        private readonly IGetAllProducts _getAllProducts;
        private readonly IGetOneProducts _getOneProducts;
        private readonly ICreateProducts _createProducts;
        private readonly IUpdateProducts _updateProducts;
        private readonly IDeleteProducts _deleteProducts;

        public ProductsControllers(
            [FromKeyedServices("IGetAllProducts")] IGetAllProducts getAllProducts,
            [FromKeyedServices("IGetOneProducts")] IGetOneProducts getOneProducts,
            [FromKeyedServices("ICreateProducts")] ICreateProducts createProducts,
            [FromKeyedServices("IUpdateProducts")] IUpdateProducts updateProducts,
            [FromKeyedServices("IDeleteProducts")] IDeleteProducts deleteProducts
        )
        {
            _getAllProducts = getAllProducts;
            _getOneProducts = getOneProducts;
            _createProducts = createProducts;
            _updateProducts = updateProducts;
            _deleteProducts = deleteProducts;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductResponseDto>>> GetAllProducts()
        {
            var products = await _getAllProducts.handle();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductResponseDto>> GetOneProducts(int id)
        {
            var product = await _getOneProducts.handle(id);

            return product == null ? NotFound() : Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<ProductResponseDto>> CreateProducts(ProductInsertDto productCreate)
        {
            var product = await _createProducts.handle(productCreate);

            return CreatedAtAction(nameof(GetOneProducts), new { id = product.ProductId }, product);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<ProductResponseDto>> UpdateProducts(int id, ProductUpdateDto productUpdate)
        {
            var product = await _updateProducts.handle(id, productUpdate);

            return product == null ? NotFound() : Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductResponseDto>> DeleteProducts(int id)
        {
            var product = await _deleteProducts.handle(id);

            return product == null ? NotFound() : Ok(product);
        }
    }
}
