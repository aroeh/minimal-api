using WeatherApi.Models;

namespace WeatherApi.Repos
{
    public interface IWeatherRepo
    {
        /// <summary>
        /// Moved from the default template.
        /// Returns a collection of randomly generated weather forecasts
        /// </summary>
        /// <returns>IEnumerable<WeatherForecast></returns>
        Task<IEnumerable<WeatherForecast>> GetRandomWeather();

        /// <summary>
        /// This won't really do anything.  It's here to show how to bind
        /// to the http request body
        /// </summary>
        /// <param name="forecast"></param>
        /// <returns>bool</returns>
        Task<bool> AddWeatherRecord(WeatherForecast forecast);

        /// <summary>
        /// This won't really do anything.  It's here to show how to bind
        /// to the http request body
        /// </summary>
        /// <param name="forecast"></param>
        /// <returns>bool</returns>
        Task<bool> UpdateWeatherRecord(WeatherForecast forecast);
    }
}
