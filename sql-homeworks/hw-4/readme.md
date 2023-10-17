# SQL �ALI�MASI �DEV-4
---
## �stenilen : 

A�a��daki sorgu senaryolar�n� dvdrental �rnek veri taban� �zerinden ger�ekle�tiriniz.

1- Film tablosunda bulunan replacement_cost s�tununda bulunan birbirinden farkl� de�erleri s�ralay�n�z.
```sql
SELECT DISTINCT replacement_cost FROM film;
```

**��kt�:**

2- Film tablosunda bulunan replacement_cost s�tununda birbirinden farkl� ka� tane veri vard�r?
```sql
SELECT (COUNT(DISTINCT replacement_cost)) FROM film;
```

**��kt�:**


3- Film tablosunda bulunan film isimlerinde (title) ka� tanesini T karakteri ile ba�lar ve ayn� zamanda rating 'G' ye e�ittir?
```sql
SELECT (COUNT(title)) FROM film WHERE title LIKE 'T%' AND rating = 'G' ;
```

**��kt�:**

4- Country tablosunda bulunan �lke isimlerinden (country) ka� tanesi 5 karakterden olu�maktad�r?
```sql
SELECT (COUNT(country)) FROM Country WHERE country LIKE '_____';
```

**��kt�:**


5- City tablosundaki �ehir isimlerinin ka� tanesi 'R' veya r karakteri ile biter?
```sql
SELECT (COUNT(city)) FROM City WHERE city ILIKE '%R';
```

**��kt�:**



---

## Kullan�lan Teknolojiler:

-  Postgresql
- [**dvdrental** �rnek veritaban�](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 

