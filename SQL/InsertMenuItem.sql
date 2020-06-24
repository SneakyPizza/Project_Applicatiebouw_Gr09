USE [dbchapoo09] --menutypeID: 1=gewone drank. 2=alcohol. 3=lunch. 4=diner

--lunch
INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Steak tartaar met truffelmayonaise', '06/12/2020', 5, 7.50, 3);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Paté van fazant met monegaskische uitjes','06/12/2020', 5, 8.50, 3);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Provencaalse vissoep met rouille, oude kaas en croutons', '06/12/2020', 5, 6.50, 3);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Hertenstoofpotje met rode kool', '06/12/2020', 5, 12.50, 3);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Gebakken kabeljauw met curry-sabayon', '06/12/2020', 5, 14.50, 3);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Linguini met paddestoelen saus', '06/12/2020', 5, 13.50, 3);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Taart van witte chocolade en speculaas met mandarijn', '06/12/2020', 5, 5.50, 3);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Verse madeleines met vijgen compote en creme patissiermet grand manier', '06/12/2020', 5, 6.50, 3);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('3 soorten boerenkazen met rogge rozijnenbrood', '06/12/2020', 5, 5.00, 3);

--diner
INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Kalfstartaar met tonijnmayonaise en gefrituurde mosselen', '06/12/2020', 5, 8.50, 4);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Paté van fazant met Monegaskische uitjes', '06/12/2020', 5, 8.50, 4);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Krab-zalm koekjes met zoetzure-chillisaus', '06/12/2020', 5, 9.00, 4);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Provencaalse vissoep met rouille en croutons', '06/12/2020', 5, 6.50, 4);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Consommé van fazant met bosui en groene kruiden', '06/12/2020', 5, 7.50, 4);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Op de huid gebakken kabeljauw rug filet met curry-sabayon', '06/12/2020', 5, 17.50, 4);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Gebakken ossenhaas met kalf-jus met roze pepers', '06/12/2020', 5, 22.50, 4);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Hertenbiefstuk met eigen stoof en rode kool', '06/12/2020', 5, 25.00, 4);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Café surprise (Koffie met huisgemaakte bonbons)', '06/12/2020', 5, 5.50, 4);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Cherry Baby (Slagroomijs met warme kersen)', '06/12/2020', 5, 6.50, 4);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Port e Fromage (verschillende kazen met glaasje port)', '06/12/2020', 5, 7.50, 4);

--gewone dranken
INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Spa rood', '06/12/2020', 5, 2.50, 1);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Spa groen',  '06/12/2020', 5,2.50, 1);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Coca Cola Light', '06/12/2020', 5, 2.50, 1);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Coca Cola', '06/12/2020', 5, 2.50, 1);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Sisi', '06/12/2020', 5, 2.50, 1);

INSERT INTO MenuItem (MenuItemName, ShelfLife,Stock,  PricePP, MenuTypeID) 
VALUES ('Tonic', '06/12/2020', 5, 2.50, 1);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Bitter Lemon', '06/12/2020', 5, 2.50, 1);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Koffie', '06/12/2020', 5, 2.50, 1);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Cappuchino', '06/12/2020', 5, 3.50, 1);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Espresso', '06/12/2020', 5, 3.00, 1);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Thee', '06/12/2020', 5, 2.50, 1);

--alcoholische dranken
INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Hertog Jan', '06/12/2020', 5, 3.00, 2);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Duvel', '06/12/2020',0, 4.50, 2);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Kriek', '06/12/2020', 5, 4.00, 2);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Leffe Triple', '06/12/2020', 5, 4.50, 2);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Witte huiswijn (fles)', '06/12/2020', 5, 28.50, 2);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Witte huiswijn (glas)', '06/12/2020', 5, 6.50, 2);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Rode huiswijn (fles)', '06/12/2020', 5, 32.00, 2);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Rode huiswijn (glas)', '06/12/2020', 5, 7.50, 2);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Champagne (fles)', '06/12/2020', 5, 50.00, 2);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Jonge Jenever', '06/12/2020', 5, 3.50, 2);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Whiskey', '06/12/2020', 5, 5.00, 2);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Rum', '06/12/2020', 5, 5.00, 2);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Vieux', '06/12/2020', 5, 4.50, 2);

INSERT INTO MenuItem (MenuItemName, ShelfLife, Stock, PricePP, MenuTypeID) 
VALUES ('Berenburg', '06/12/2020', 5, 3.50, 2);
