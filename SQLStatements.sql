use Games_Rental_System;

go
/*a*/
Select * from Game
select * from Rent 
SELECT top 1 G_NAME
FROM  GAME g  join Rent r
on g.GAME_ID  =r.GAME_ID
GROUP BY G_NAME
order by count(r.CLIENT_ID ) desc
/*b*/
Select * from Rent
Select * From GAME
SELECT distinct G_NAME, DateOfRenting
FROM   GAME g  join  Rent r
on g.GAME_ID=r.GAME_ID
WHERE r.GAME_ID  not in (select GAME_ID  From  Rent where DATEOFRENTING> DATEADD(MONTH, -1, GETDATE()))

/*c*/
select * from Client
select * from Rent
SELECT top 1 C_FIRSTNAME, C_LASTNAME
FROM  CLIENT c  join Rent r
on c.CLIENT_ID =r.CLIENT_ID
where DATEOFRENTING <= DATEADD(MONTH, -1, GETDATE()) AND DATEOFRENTING >= DATEADD(MONTH, -2, GETDATE())
GROUP BY C_FIRSTNAME,C_LASTNAME
order by count(r.CLIENT_ID) desc


/*d*/
select * from Vendor
select * from Rent
SELECT top 1 V_FIRSTNAME, V_LASTNAME
FROM  VENDOR v join Rent r
on v.VENDOR_ID =r.Vendor_ID
where DATEOFRENTING <= DATEADD(MONTH, -1, GETDATE()) AND   DATEOFRENTING >= DATEADD(MONTH, -2, GETDATE())
GROUP BY V_FIRSTNAME,V_LASTNAME
order by count(r.Vendor_ID) desc

/*e*/
select * from Vendor
select * from Rent
SELECT distinct V_FIRSTNAME, V_LASTNAME
FROM  VENDOR v  join  Rent r
on  v.VENDOR_ID=r.VENDOR_ID
WHERE v.VENDOR_ID  not in (select VENDOR_ID  From Rent where DATEOFRENTING< DATEADD(MONTH, -1, GETDATE()))

/*f*/
select * from Vendor
select * from GAME
SELECT V_FIRSTNAME, V_LASTNAME
FROM  VENDOR v  join Game g
on    v.VENDOR_ID=g.VENDOR_ID
WHERE v.VENDOR_ID not in  (select VENDOR_ID From  Game  where  AdditionDate  < DATEADD(YEAR, -1, GETDATE()) and AdditionDate > DATEADD(YEAR, -2, GETDATE()))