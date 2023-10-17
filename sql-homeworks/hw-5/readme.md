# SQL �ALI�MASI �DEV-5
---
## �stenilen : 

A�a��daki sorgu senaryolar�n� dvdrental �rnek veri taban� �zerinden ger�ekle�tiriniz:

1- Film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en uzun (length) 5 filmi s�ralay�n�z.

```sql
SELECT title,film.length FROM film WHERE title LIKE '%n' ORDER BY film.length DESC LIMIT 5;
```

**��kt�:**


2-Film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en k�sa (length) ikinci(6,7,8,9,10) 5 filmi(6,7,8,9,10) s�ralay�n�z.

```sql
SELECT title,film.length FROM film WHERE title LIKE '%n' ORDER BY film.length LIMIT 5 OFFSET 5;
```

**��kt�:**


3-Customer tablosunda bulunan last_name s�tununa g�re azalan yap�lan s�ralamada store_id 1 olmak ko�uluyla ilk 4 veriyi s�ralay�n�z. ( IN operat�r�n� kullan�n�z.)


```sql
SELECT * FROM customer WHERE store_id=1 ORDER BY last_name DESC LIMIT 4;
```

**��kt�:**


---

## Kullan�lan Teknolojiler:

-  Postgresql
- [**dvdrental** �rnek veritaban�](https://www.postgresqltutorial.com/wp-content/uploads/2019/05/dvdrental.zip) 
