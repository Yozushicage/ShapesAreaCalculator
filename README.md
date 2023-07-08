## 1. ������ ������������� ����������
```js
var circle = ShapesFactory.CreateCircle(10);
var circleArea = circle.Area;

var triangle = ShapesFactory.CreateTriangle(6, 10, 8) as Triangle;
var triangleArea = triangle?.Area;
var isRightAngled = triangle?.IsRightAngled;
```

## 2. ������ ���������� � ����� [Query.sql](https://github.com/Yozushicage/ShapesAreaCalculator/blob/main/Query.sql)