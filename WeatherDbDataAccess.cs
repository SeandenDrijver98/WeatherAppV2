using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace WeatherAppV2
{
    class WeatherDbDataAccess
    {

        //-------------------------------------
        // QUERY COMMANDS
        //-------------------------------------

        //Get All Users
        public static List<UserModel> getAllUsers()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var users = connection.Query<UserModel>("SELECT * FROM User", new DynamicParameters());
                return users.ToList();
            }
        }

        //Get all Forecasts
        public static List<ForecastModel> getAllForecasts()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var forecasts = connection.Query<ForecastModel>("SELECT * FROM Forecast", new DynamicParameters());
                return forecasts.ToList();
            }
        }

        //Create a new user
        public static void CreateUser(UserModel user)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("INSERT INTO User (email, password, permissions,favourite_city) Values (@email, @password, @permissions, @favCity)", user);
            }

        }

        //Create a new Forecast
        public static void CreateForecast(ForecastModel forecast)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("INSERT INTO Forecast (city, date, condition, precipitation, max_temp, min_temp, windspeed, humidity) " +
                    "Values (@city, @date, @condition, @precipitation, @max_temp, @min_temp, @windspeed, @humidity)", forecast);
            }

        }

        //Get User
        public static List<UserModel> GetUser(UserModel user)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var loginUser = connection.Query<UserModel>("Select * FROM User WHERE email IS @email AND password IS @password", user);
                return loginUser.ToList();

            }
        }

        //Get Forecast by date and town

        public static List<ForecastModel> getWeather(ForecastModel searchObj)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var foundForecast = connection.Query<ForecastModel>("Select * FROM Forecast WHERE city IS @city AND date IS @date", searchObj);
                return foundForecast.ToList();

            }
        }
        //Get forecast by date range and town
        public static List<ForecastModel> getCityWeatherRange(ForecastModel searchObj)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var foundForecast = connection.Query<ForecastModel>("Select * FROM Forecast WHERE city IS @city AND date BETWEEN @date AND @endDate", searchObj);
                return foundForecast.ToList();

            }
        }

        //Get forecast by date range
        public static List<ForecastModel> getWeatherRange(ForecastModel searchObj)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var foundForecast = connection.Query<ForecastModel>("Select * FROM Forecast WHERE date BETWEEN @date AND @endDate", searchObj);
                return foundForecast.ToList();

            }
        }

        public static List<string[]> toArray(List<ForecastModel> models)
            {
            List<string[]> arrayList = new List<string[]>();
            foreach (var model in models)
            {
                string[] forecastArr = { model.city, model.date + "", model.condition, model.precipitation + "", model.max_temp + "", model.min_temp + "", model.windspeed + "", model.humidity + "" };
                arrayList.Add(forecastArr);
            }
            return arrayList;
                
            }

        public static void deleteRecord(ForecastModel forecast)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Query<ForecastModel>("DELETE FROM Forecast WHERE forecast_id IS @forecast_id", forecast);
            }
        }

        public static void editRecord(ForecastModel forecast)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("UPDATE Forecast SET (city, date, condition, precipitation, max_temp, min_temp, windspeed, humidity) = (@city, @date, @condition, @precipitation, @max_temp, @min_temp, @windspeed, @humidity) WHERE forecast_id IS @forecast_id", forecast);

            }
        }

        //-------------------------------------
        // Get the connection string
        //-------------------------------------
        private static string LoadConnectionString(String Id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[Id].ConnectionString;
        }
    }
}
