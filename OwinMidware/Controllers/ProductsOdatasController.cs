using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using OwinMidware.Models;
using Microsoft.Data.OData;

namespace OwinMidware.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using OwinMidware.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<ProductsOdata>("ProductsOdatas");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class ProductsOdatasController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/ProductsOdatas
        public IHttpActionResult GetProductsOdatas(ODataQueryOptions<ProductsOdata> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<IEnumerable<ProductsOdata>>(productsOdatas);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // GET: odata/ProductsOdatas(5)
        public IHttpActionResult GetProductsOdata([FromODataUri] int key, ODataQueryOptions<ProductsOdata> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<ProductsOdata>(productsOdata);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/ProductsOdatas(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<ProductsOdata> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(productsOdata);

            // TODO: Save the patched entity.

            // return Updated(productsOdata);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/ProductsOdatas
        public IHttpActionResult Post(ProductsOdata productsOdata)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(productsOdata);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/ProductsOdatas(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<ProductsOdata> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(productsOdata);

            // TODO: Save the patched entity.

            // return Updated(productsOdata);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/ProductsOdatas(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }
    }
}
