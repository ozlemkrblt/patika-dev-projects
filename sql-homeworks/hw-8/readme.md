# SQL ÇALIŞMASI ÖDEV-8
---
## İstenilen : 

Asagidaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleþtiriniz:

1- Test veritabanınızda *employee* isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.



```sql
CREATE TABLE employee (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50),
    birthday DATE,
    email VARCHAR(100)
);
```

**Çıktı:**
![t1](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/5c7ed428-8d72-4112-921c-ef74b199d154)


2-Oluþturduğumuz *employee* tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
.

```sql
insert into employee (id, name, birthday, email) values (1, 'Bettina Wavish', '12/11/2019', 'bwavish0@ox.ac.uk');
insert into employee (id, name, birthday, email) values (2, 'Godwin Jurisic', '09/06/1960', 'gjurisic1@forbes.com');
insert into employee (id, name, birthday, email) values (3, 'Eleanora Comello', '03/01/1942', 'ecomello2@chron.com');
insert into employee (id, name, birthday, email) values (4, 'Dena Rae', '05/10/1992', 'drae3@deviantart.com');
insert into employee (id, name, birthday, email) values (5, 'Amery Balderson', '28/11/1978', 'abalderson4@jimdo.com');
insert into employee (id, name, birthday, email) values (6, 'Marcie Berends', '17/04/1981', 'mberends5@g.co');
insert into employee (id, name, birthday, email) values (7, 'Barny Pavek', '11/02/1993', 'bpavek6@merriam-webster.com');
insert into employee (id, name, birthday, email) values (8, 'Cordey Todarello', '14/08/1939', 'ctodarello7@exblog.jp');
insert into employee (id, name, birthday, email) values (9, 'Tomasina Falkingham', '10/05/1933', 'tfalkingham8@wikimedia.org');
insert into employee (id, name, birthday, email) values (10, 'Merrily Stollhofer', '02/11/1952', 'mstollhofer9@taobao.com');
insert into employee (id, name, birthday, email) values (11, 'Lissi Sworne', '06/10/1960', 'lswornea@hugedomains.com');
insert into employee (id, name, birthday, email) values (12, 'Cecilia Ovill', '10/12/2002', 'covillb@newyorker.com');
insert into employee (id, name, birthday, email) values (13, 'Basilius Haselup', '16/08/2019', 'bhaselupc@europa.eu');
insert into employee (id, name, birthday, email) values (14, 'Chilton Hancox', '24/06/1991', 'chancoxd@altervista.org');
insert into employee (id, name, birthday, email) values (15, 'Clayson Amiss', '06/06/2015', 'camisse@geocities.com');
insert into employee (id, name, birthday, email) values (16, 'Antony Gheorghie', '09/09/1946', 'agheorghief@free.fr');
insert into employee (id, name, birthday, email) values (17, 'Ashley Dello', '09/10/1991', 'adellog@jimdo.com');
insert into employee (id, name, birthday, email) values (18, 'Esmaria Ewington', '01/08/1931', 'eewingtonh@ehow.com');
insert into employee (id, name, birthday, email) values (19, 'Caty Lindenboim', '06/07/1975', 'clindenboimi@domainmarket.com');
insert into employee (id, name, birthday, email) values (20, 'Gabbey Bulfoot', '18/12/1990', 'gbulfootj@bbb.org');
insert into employee (id, name, birthday, email) values (21, 'Raff Novotni', '01/10/2010', 'rnovotnik@disqus.com');
insert into employee (id, name, birthday, email) values (22, 'Wesley Daymont', '14/12/2005', 'wdaymontl@printfriendly.com');
insert into employee (id, name, birthday, email) values (23, 'Delmor Idale', '16/04/1988', 'didalem@house.gov');
insert into employee (id, name, birthday, email) values (24, 'Wallis Kenney', '18/02/1956', 'wkenneyn@hhs.gov');
insert into employee (id, name, birthday, email) values (25, 'Roseanne Nason', '01/03/2011', 'rnasono@google.com.br');
insert into employee (id, name, birthday, email) values (26, 'York MacDonagh', '01/11/1995', 'ymacdonaghp@w3.org');
insert into employee (id, name, birthday, email) values (27, 'Ben Ianelli', '07/03/2020', 'bianelliq@redcross.org');
insert into employee (id, name, birthday, email) values (28, 'Bronny Lindelof', '09/09/1970', 'blindelofr@mtv.com');
insert into employee (id, name, birthday, email) values (29, 'Claudine Izkovitz', '03/03/2015', 'cizkovitzs@java.com');
insert into employee (id, name, birthday, email) values (30, 'Janette Ruddin', '04/12/1993', 'jruddint@imgur.com');
insert into employee (id, name, birthday, email) values (31, 'Glynn Musla', '31/01/1943', 'gmuslau@cyberchimps.com');
insert into employee (id, name, birthday, email) values (32, 'Verne Jakaway', '16/03/1966', 'vjakawayv@tinyurl.com');
insert into employee (id, name, birthday, email) values (33, 'Jennifer Jacobowits', '31/08/1987', 'jjacobowitsw@constantcontact.com');
insert into employee (id, name, birthday, email) values (34, 'Anthony Garrison', '22/04/1938', 'agarrisonx@taobao.com');
insert into employee (id, name, birthday, email) values (35, 'Doreen Lawerence', '29/07/1942', 'dlawerencey@istockphoto.com');
insert into employee (id, name, birthday, email) values (36, 'Elenore Sey', '03/06/2020', 'eseyz@mapy.cz');
insert into employee (id, name, birthday, email) values (37, 'Heida Redfern', '09/06/1969', 'hredfern10@webnode.com');
insert into employee (id, name, birthday, email) values (38, 'Cameron Kedwell', '31/08/2016', 'ckedwell11@jugem.jp');
insert into employee (id, name, birthday, email) values (39, 'Linn Puttergill', '15/09/1944', 'lputtergill12@xinhuanet.com');
insert into employee (id, name, birthday, email) values (40, 'Electra Putson', '21/05/1976', 'eputson13@cnn.com');
insert into employee (id, name, birthday, email) values (41, 'Eloise Mahoney', '11/09/1985', 'emahoney14@va.gov');
insert into employee (id, name, birthday, email) values (42, 'Nickey McGuigan', '02/04/2019', 'nmcguigan15@huffingtonpost.com');
insert into employee (id, name, birthday, email) values (43, 'Alexia Lapre', '09/11/1988', 'alapre16@hhs.gov');
insert into employee (id, name, birthday, email) values (44, 'Pate Bim', '27/03/1966', 'pbim17@redcross.org');
insert into employee (id, name, birthday, email) values (45, 'Trina Boots', '21/04/1966', 'tboots18@un.org');
insert into employee (id, name, birthday, email) values (46, 'Sawyere Whaymand', '06/06/2019', 'swhaymand19@ovh.net');
insert into employee (id, name, birthday, email) values (47, 'Kahlil Bugdall', '16/03/1937', 'kbugdall1a@com.com');
insert into employee (id, name, birthday, email) values (48, 'Cleavland Rawles', '27/09/2001', 'crawles1b@creativecommons.org');
insert into employee (id, name, birthday, email) values (49, 'Wren Pengelley', '11/03/1966', 'wpengelley1c@ebay.co.uk');
insert into employee (id, name, birthday, email) values (50, 'Ewen Alldread', '10/01/1943', 'ealldread1d@slashdot.org');



SELECT * FROM employee;
```

**Çıktı:**

![t2](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/7d9d10d8-a9dd-4557-9407-36edb761b799)
![t2 1](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/66b2bcc5-3aac-49b7-adb2-8440953260a7)


3-Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.


```sql
UPDATE employee SET name = 'Alexia Whaymand' WHERE id = 43;
UPDATE employee SET birthday = '1999-10-12' WHERE name = 'Ewen Alldread';
UPDATE employee SET name = 'Thomas Cerdino', birthday = '1990-05-20', email = 'thcer@blog.com' WHERE id=8;
UPDATE employee SET email = 'mmcguigan15@un.org' WHERE birthday = '2019-04-02';
UPDATE employee SET name = 'Mickey McGuigan', birthday = '1992-05-15' WHERE email = 'mmcguigan15@un.org';

SELECT * FROM employee;

```

**Çıktı:**
![t3](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/9c17e302-53cc-4621-abb0-12ca259b89a2)

![t3 1](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/df1b7d70-650e-4d93-9604-0bdc1f12cf3e)

4-Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.

```sql
DELETE FROM employee WHERE id IN(24,12,11);

DELETE FROM employee WHERE name LIKE('El%');

DELETE FROM employee WHERE EXTRACT(YEAR FROM birthday) < '1943';

DELETE FROM employee WHERE email = 'bpavek6@merriam-webster.com';

DELETE FROM employee WHERE id = 50;

SELECT * FROM employee;

```
**Çıktı:**
1.  ![t4 1](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/373b70b9-2726-4b99-82cd-f84dddc4e7d3)

2.
Önce: 

![t4 2](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/ecbbb6f5-b4e8-4775-b6e4-f3885dc5d51b)

Sonra:

![t4 2 2](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/b6dba7e2-0eaf-4423-bdc9-8eab353e1829)

3. 
Önce: 

![t4 3 1](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/3111c14e-a471-4fa5-8ca2-94c3c05858f3)

Sonra:

![t4 3 2](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/b1d17713-f919-4ca5-baa7-271ea6ab455b)

4.
Önce:

![t4 4 1](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/7d7ffdb5-f8e4-460d-ad8a-1e340e3db89c)

Sonra:

![t4 4 2](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/535b0de7-ac9d-456b-8f26-08105bb0f6b1)

5.
Önce: 

![t4 5 1](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/fddcee6f-7873-4fa5-9ff2-3ebcd72eb880)

Sonra:

![t4 5 2](https://github.com/ozlemkrblt/patika-dev-projects/assets/46456721/a6b966e8-0bef-4529-9060-f61b053a098d)

---
## Kullanılan Teknolojiler:

-  Postgresql
- [Mockaroo.com](https://www.mockaroo.com/) 
