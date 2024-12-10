using BlazorServer.Models;

namespace BlazorServer.Services.Interfaces;

public interface IWeatherService
{
    Task<List<WeatherForecast>> GetAsync();
}