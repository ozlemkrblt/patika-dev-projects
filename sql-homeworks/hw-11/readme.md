# SQL �ALI�MASI �DEV-11
---
## �stenilen : 

A�a��daki sorgu senaryolar�n� dvdrental �rnek veri taban� �zerinden ger�ekle�tiriniz:

1- Actor ve customer tablolar�nda bulunan first_name s�tunlar� i�in t�m verileri s�ralayal�m.


```sql
SELECT first_name FROM actor UNION SELECT first_name FROM customer;
```

**��kt�:**



2- Actor ve customer tablolar�nda bulunan first_name s�tunlar� i�in kesi�en verileri s�ralayal�m.

```sql
SELECT first_name FROM actor INTERSECT SELECT first_name FROM customer;
```

**��kt�:**



3- Actor ve customer tablolar�nda bulunan first_name s�tunlar� i�in ilk  tabloda bulunan ancak ikinci tabloda bulunmayan verileri s�ralayal�m.



```sql
SELECT first_name FROM actor EXCEPT ALL SELECT first_name FROM customer;
```

**��kt�:**


---

## Kullan�lan Teknolojiler:

-  Postgresql
- [**dvdrental** �rnek veritaban�](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
