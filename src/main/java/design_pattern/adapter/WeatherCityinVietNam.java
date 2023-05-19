package design_pattern.adapter;



import java.util.Arrays;
import java.util.List;
import java.util.Random;

class WeatherCityInVietNam implements Weather {
    private List<String> vietnamCities = Arrays.asList("Hà Nội", "Hồ Chí Minh", "Đà Nẵng");
    private boolean isCityInVietNam(String city) {
        return vietnamCities.contains(city);
    }

    private int generateRandomTemperature() {
        Random random = new Random();
        int minTemperature = 30;
        int maxTemperature = 40;
        return random.nextInt(maxTemperature - minTemperature + 1) + minTemperature;
    }

    private int generateRandomHumidity() {
        Random random = new Random();
        int minHumidity = 40;
        int maxHumidity = 80;
        return random.nextInt(maxHumidity - minHumidity + 1) + minHumidity;
    }

    @Override
    public String getWeather(String city) {
        if (!isCityInVietNam(city)) {
            return "Không hỗ trợ thông tin thời tiết cho thành phố này.";
        }

        int temperature = generateRandomTemperature();
        int humidity = generateRandomHumidity();

        return "Thành phố: " + city + "\nNhiệt độ: " + temperature + "°C\nĐộ ẩm: " + humidity + "%";
    }

}
