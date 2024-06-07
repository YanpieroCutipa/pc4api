using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.ML;
using pc4api_ML;
using pc4api.Data;
using pc4api.Service;
using Microsoft.Extensions.ML;
using pc4api.Models;


namespace pc4api.Controllers
{
    public class ML2Controller : Controller
    {
        private readonly ILogger<ML2Controller> _logger;
        private readonly PredictionEnginePool<ProductoRating, ProductoRatingPrediction> _model;
        private readonly Productos _productos;


        public ML2Controller(ILogger<ML2Controller> logger,
        PredictionEnginePool<ProductoRating, ProductoRatingPrediction> model,
        Productos productos)
        {
            _logger = logger;
             _model = model;
            _productos = productos;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Predict(int id)
        {
            List<(int productoId, float normalizedScore)> ratings = new List<(int productoId, float normalizedScore)>();
            ProductoRatingPrediction prediction = null;

            foreach (var producto in _productos.getAllProductos())
            {
               //  Call the Rating Prediction for each movie prediction
              prediction = _model.Predict(new ProductoRating
               {
               userid = id,
                   productoid = producto.ProductoId // Asegúrate de que coincide con el nombre de la propiedad en ProductoRating
               });

                // Normalize the prediction scores for the "ratings" b/w 0 - 100
                float normalizedscore = Sigmoid(prediction.Score);

                // Add the score for recommendation of each movie in the trending movie list
                ratings.Add((producto.ProductoId, normalizedscore));
            }
            ViewData["ratings"] = ratings;
            ViewData["trendingproductos"] = _productos.getAllProductos();
            return View("Index");
        }

        public float Sigmoid(float x)
        {
            return (float) (100/(1 + Math.Exp(-x)));
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}