# LINQ Practice

## 목차

## [Where.cs](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/Where.cs)

LINQ 에서 Where 절은 질의 결과를 제한하는 절입니다. 오직 Where 절 조건에 맞는 요소만이 결과 시퀀스에 추가되어 출력됩니다.

## [Select.cs](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/Select.cs)

Select 절은 입력 시퀀스를 원하는 출력 시퀀스로 변환합니다.

## [GroupByInto.cs](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/GroupByInto.cs)

그룹연산자 (Grouping Operators)는 group by 와 into 키워드를 사용합니다.
그룹 연산자는 입력 시퀀스를 주어진 키에 맞춰 바구니에 나눠 담습니다.

## [PartitionOperator.cs](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/PartitionOperator.cs)

LINQ 에서 제공하는 확장 메서드 중 Take, Skip, TakeWhile, SkipWhile 을 분할 연산자라고 한다. 분할 연산자는 출력 시퀀스를 분할시켜 반환한다.

## [OrderingOperator.cs](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/OrderingOperator.cs)

정렬 연산자인 OrderBy는 출력 시퀀스를 기준에 따라 정렬하는 연산자이다.

## [SetOperators.cs](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/SetOperators.cs)

집합 연산자는 두 집합 간에 관계를 활용하는 연산자입니다.

LINQ 메서드 중 Distinct, Union, Intersect, Except 가 집합 연산자에 해당합니다.

## [ConversionOperators.cs](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/ConversionOperators.cs)

변환 연산자 Conversion Operators

LINQ 구문은 IEnumeralbe 인터페이스를 반환합니다. 하지만 코드를 작성하다보면 인터페이스가 아닌 구체화된 클래스가 필요할 때가 있습니다. 그 때 변환 연산자를 활용하여 Array, List, Dictionary 타입으로 변환할 수 있습니다.

> 주의사항 LINQ 구문은 Lazy 전략을 사용하여 코드가 정의되어 있는 구간에서 실행되지 않습니다. 그런데 변환 연산자를 사용하게 되면 바로 연산을 끝내기 때문에 연산이 많은 LINQ 구문은 성능에 영향을 미칠 수 있습니다.

## [ElementOperators.cs](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/ElementOperators.cs)

요소 연산자는 LINQ 구문 결과에서 원하는 위치의 요소 하나를 선택할 때 사용하는 연산자입니다.

> 정렬 연산자 orderby와 같이 사용하는 경우가 많습니다.

## [RangeRepeat.cs](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/RangeRepeat.cs)

Range 메서드는 특정 범위의 숫자 집합을 만들 때 사용하는 메서드입니다.
Repeat 메서드는 특정 숫자를 특정 횟수만큼 반복한 집합을 만들 때 사용하는 메서드입니다.

## [Quantifiers.cs](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/Quantifiers.cs)

수량자 Quantifiers

마이크로소프트의 공식 번역은 '수량자'이지만 수량과는 전혀 상관이 없다.
Any 메서드는 집합 안에 조건에 맞는 요소가 하나라도 있는지 확인하는 메서드이고, All 메서드는 집합 안에 모든 요소가 조건에 맞는지 확인하는 메서드입니다.

## [Aggregators](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/Aggregators)

집계 작업은 집합 모든 요소를 계산하여 하나의 값으로 변환하는 작업입니다. 집계 작업에 해당하는 LINQ 메서드로는 Count, Sum, Min, Max, Average, Aggregate가 있습니다.

## [Count.cs](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/Aggregators/Count.cs)

집합 내 요소 개수 세기

## [Sum.cs](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/Aggregators/Sum.cs)

집합 내 모든 원소 더하기

## [Min.cs](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/Aggregators/Min.cs)

집합 내 최솟값 찾기

## [Max.cs](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/Aggregators/Max.cs)

집합 내 최댓값 찾기

## [Average.cs](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/Aggregators/Average.cs)

집합 내에서 평균값 계산하기

## [Aggregate.cs](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/Aggregators/Aggregate.cs)

Enumeralbe.Aggregate 메서드는 합계, 총액 즉 누산기다.

## [SequenceOperations.cs](https://github.com/twozeronine/Coding_Test/blob/main/LINQ%20Practice/SequenceOperations.cs)

시퀀스 작업에 포함된 메서드는 SequenceEqual, Concat, Zip 입니다. 시퀀스 작업 메서드는 집합 전체를 대상으로 작업합니다.

## JoinOperations

조인은 데이터베이스에 등장하는 개념이다. 조인 작업은 집합 간에 데이터를 연결한다. 조인 작업은 클래스간에 참조 관계가 없더라도 데이터를 연결할 수 있다.

```C#
  class Customer
  {
    public City city {get; set;}
  }
  class City
  {
    public string Name {get; set;}
  }

  public static Enumerable<Tuple<City, Enumerable<Customer>>> FindAllCustomersInCity (Enumerable<Customer> allCustomers, Enumerable<City> allCities)
  {
    var query = from city in allCities
                join customer in allCustomers on city.Name equals customer.City.Name into customersInCities
                select ( City : city, Customers : customersInCities);
   }
```

> 자료 출처: https://ibocon.tistory.com/
