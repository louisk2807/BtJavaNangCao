package design_pattern.adapter;

import java.util.Random;

public class OpenWeather {
    private int generateRandomTemperature() {

        Random random = new Random();
        int minTemperature = 60;
        int maxTemperature = 120;
        return random.nextInt(maxTemperature - minTemperature + 1) + minTemperature;
    }

    private int generateRandomHumidity() {

        Random random = new Random();
        int minHumidity = 40;
        int maxHumidity = 80;
        return random.nextInt(maxHumidity - minHumidity + 1) + minHumidity;
    }

    public String getWeatherCity(String cityName) {
        int temperature = generateRandomTemperature();
        int humidity = generateRandomHumidity();
        int windSpeed = 3; // Gió: 3 m/s
        int pressure = 100; // Áp suất: 100 Pa

        return "City: " + cityName + "\nTemperature: " + temperature + "°F\nHumidity: " + humidity +
                "%\nWind Speed: " + windSpeed + " m/s\nPressure: " + pressure + " Pa";
    }
}
