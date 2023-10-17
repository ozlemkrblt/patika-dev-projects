# SQL ÇALIŞMASI ÖDEV-1 
---
## İstenilen : 

Aşağıdaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleştiriniz:

1- Film tablosunda bulunan title ve description sütunlarındaki verileri sıralayınız.

```sql
SELECT title,description FROM Film;
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/5c7791c8-ccc5-4df4-abce-ee5382b3c924)

2-Film tablosunda bulunan tüm sütunlardaki verileri film uzunluğu (length) 60 dan büyük VE 75 ten küçük olma koşullarıyla sıralayınız.

```sql
SELECT title,length FROM Film WHERE film.length BETWEEN 60 AND 75 ORDER BY length;
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/196d14d8-575c-4c24-849b-d6ab17cd3f2d)

3-Film tablosunda bulunan tüm sütunlardaki verileri rental_rate 0.99 VE replacement_cost 12.99 VEYA 28.99 olma koşullarıyla sıralayınız.

```sql
SELECT title,rental_rate,replacement_cost FROM Film WHERE rental_rate= 0.99 AND replacement_cost IN (12.99,28.99);
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/05407959-f6d8-48cb-b2ef-ea2eecf660eb)

4-Customer tablosunda bulunan first_name sütunundaki değeri 'Mary' olan müşterinin last_name sütunundaki değeri nedir?

```sql
SELECT first_name,last_name FROM Customer WHERE first_name='Mary';
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/d2fcb6af-87e6-4b8b-a66d-108c0d16c89a)


5-Film tablosundaki uzunluğu(length) 50 ten büyük OLMAYIP aynı zamanda rental_rate değeri 2.99 veya 4.99 OLMAYAN verileri sıralayınız.

```sql
SELECT title,length,rental_rate FROM Film WHERE length <50 AND rental_rate NOT IN (2.99,4.99);
```

**Çıktı:**

![image](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/0fd26a39-01c4-427f-b3a5-9794ccc7b4d1)


---

## Kullanılan Teknolojiler:

-  Postgresql
- [**dvdrental** örnek veritabanı](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
