![apple-icon-57x57](https://user-images.githubusercontent.com/23481104/29523079-02faa12e-868c-11e7-9172-c35243999a3b.png) 
# Home Automation
This repository is for my home automation IoT project using ESP8266 ESP-12E and sensors.

## Electronics
The ESP8266 ESP12E is programmed and powered using a micro USB cable.


### Parts list
|Part|Price|
|:---|---:|
|[ESP8266 - ESP12E](https://www.aliexpress.com/item/ESP8266-ESP-12-NodeMCU-Lua-WiFi-Internet-Things-Development-Board/32368848967.html)|$3.33|
|[HC-SR501 - PIR motion sensor](https://www.aliexpress.com/item/HC-SR501-Adjust-IR-Pyroelectric-Infrared-PIR-Human-Motion-Sensor-Detector-Module-DC-5V-20V/32540364838.html)|$1.05|
|[Breadboard](https://www.aliexpress.com/item/Breadboard-830-Point-Solderless-PCB-Bread-Board-MB-102-MB102-Test-Develop-DIY/32671276515.html)|$1.65|
|[DHT11 - Digital temperature & humidity sensor](https://www.aliexpress.com/item/Smart-3pin-KEYES-KY-015-DHT-11-DHT11-Digital-Temperature-And-Relative-Humidity-Sensor-Module-PCB/32730774914.html)|$0.83|
|[YL-69 - Soil moisture sensor](https://www.fasttech.com/products/0/10004911/4738201-yl-69-soil-humidity-moisture-detection-sensor)|$1.49|
|*Total:*|$8.35|



### Schematics
![esp8266_esp12e_set-up_bb](https://user-images.githubusercontent.com/23481104/29522486-8f887ae2-8689-11e7-8a70-ac19f270b20a.png)

__IMPORTANT!__
The PIR motion sensor takes 5v as input, which the ESP8266 ESP-12E can't provide. However, internally the PIR motion sensor operates at 3.3v. This means that it's possible to bypass the voltage regulator and use it directly with the ESP8266 ESP-12E, without having to add a step-up regulator. The soldering is tricky, but not impossible. Observe that it's the PIN on the right side that should be soldered, not the PIN in the middle! 

Youtube instructions from EZtech: 

<a href="http://www.youtube.com/watch?feature=player_embedded&v=Jy-4Xcv4h_Y" target="_blank"><img src="http://img.youtube.com/vi/Jy-4Xcv4h_Y/0.jpg" alt="Convert a PIR Motion Sensor to 3.3v Logic for ESP8266 NodeMCU or Raspberry PI" width="240" height="180" border="10" /></a>
