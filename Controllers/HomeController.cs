using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;
using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace Proyecto.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }






// Controller action to fetch and display a list of games
public IActionResult Index()
{
    // Define the API endpoint URL for fetching games data
    string url = "https://www.mmobomb.com/api1/games";
    // Create a new HttpClient instance
    HttpClient client = new HttpClient();
    // Send a GET request to the API endpoint and get the response
    HttpResponseMessage response = client.GetAsync(url).Result;
    // Read the response content as a string
    string jsonResponse = response.Content.ReadAsStringAsync().Result;
    // Deserialize the JSON response into a list of GameModel objects
    var gameList = JsonConvert.DeserializeObject<List<GameModel>>(jsonResponse);
    // Pass the game list to the view
    return View(gameList);
}


// Controller action to fetch and display the latest news
public IActionResult LatestNews()
{
    // Define the API endpoint URL for fetching latest news data
    string url = "https://www.mmobomb.com/api1/latestnews";
    // Create a new HttpClient instance
    HttpClient client = new HttpClient();
    // Send a GET request to the API endpoint and get the response
    HttpResponseMessage response = client.GetAsync(url).Result;
    // Read the response content as a string
    string jsonResponse = response.Content.ReadAsStringAsync().Result;
    // Deserialize the JSON response into a list of NewsModel objects
    var News = JsonConvert.DeserializeObject<List<NewsModel>>(jsonResponse);
    // Pass the news list to the view
    return View(News);
}











    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
