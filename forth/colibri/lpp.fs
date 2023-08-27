\ Support for Cayenne lpp formats

\ Types
0 constant lpp-digital-input              \ 1 byte
1 constant lpp-digital-output             \ 1 byte
2 constant lpp-analog-input               \ 2 bytes, 0.01 signed
3 constant lpp-analog-output              \ 2 bytes, 0.01 signed
101 constant lpp-luminosity               \ 2 bytes, 1 lux unsigned
102 constant lpp-presence                 \ 1 byte, 1
103 constant lpp-temperature              \ 2 bytes, 0.1 Celsius signed
104 constant lpp-relative-humidity        \ 1 byte, 0.5% unsigned
113 constant lpp-accelerometer            \ 2 bytes per axis, 0.001G
115 constant lpp-barometric-pressure      \ 2 bytes 0.1 hPa Unsigned
134 constant lpp-gyrometer                \ 2 bytes per axis, 0.01 degrees/s
136 constant lpp-gps                      \ 3 byte lon/lat 0.0001 degrees, 3 bytes alt 0.01 meter

\ sizes for each type
3 constant lpp-digital-input-size         \ 1 byte
3 constant lpp-digital-output-size        \ 1 byte
4 constant lpp-analog-input-size          \ 2 bytes, 0.01 signed
4 constant lpp-analog-output-size         \ 2 bytes, 0.01 signed
4 constant lpp-luminosity-size            \ 2 bytes, 1 lux unsigned
3 constant lpp-presence-size              \ 1 byte, 1
4 constant lpp-temperature-size           \ 2 bytes, 0.1 Celsius signed
3 constant lpp-relative-humidity-size     \ 1 byte, 0.5% unsigned
8 constant lpp-accelerometer-size         \ 2 bytes per axis, 0.001G
4 constant lpp-barometric-pressure-size   \ 2 bytes 0.1 hPa Unsigned
8 constant lpp-gyrometer-size             \ 2 bytes per axis, 0.01 degrees/s
11 constant lpp-gps-size                  \ 3 byte lon/lat 0.0001 degrees, 3 bytes alt 0.01 meter