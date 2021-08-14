# Investor-s-Zone
Final project

Luk
=====================
1. Sprawdzam scie¿ke bazy danych i poprawiam na moja w³asciw¹
2. Wchodze w Tool, menadzer pakietow wybieram opcje z konsola
3. W konsoli wpisuje add-migration Init 
4. W tej samej konsoli wpisuje update-database

=====================


Grzegorz

skasowaæ katalog Migrations
podaæ dwie komendy w powershell jako administrator

dotnet ef migrations add InitialCreate

dotnet ef database update

Utworzyæ w sms bazê danych forum
podaæ w sms nastêpuj¹ce komendy do bazy forum:

DROP TABLE IF EXISTS forum;
CREATE TABLE forum (Id int IDENTITY(1,1) PRIMARY KEY, User_id varchar(255) NOT NULL, Title varchar(1000), Post varchar(8000) ); 
INSERT INTO forum (User_id, Title, Post) values (1, 'Understanding Market Cycles', 'Market cycles and trends are used to help investors predict the market. They are easy to see looking back, but much harder to pinpoint as they occur. Traders study technical analyses to try to understand how the market will move next. For the most part, professional investors follow the trend until it changes. They have a saying, The trend is your friend. What Causes a Market Cycle? The expansion and contraction of business, earnings, inflation, stability, and politics all affect market cycles. Basic human emotions and behaviors create market trends.17 People swing between fear and greed, between focusing on the good news and worrying about the negative. Markets react to the pendulum-like swing.');
INSERT INTO forum (User_id, Title, Post) values (1, 'Trading the News and Economic Calendar', 'Stocks, currencies, and commodities all respond to news, both predicted and unexpected. Because you understand that trends will eventually revert to the mean, or back to the trend, you may be able to take advantage of unexpected news. The knee-jerk response of bad news may cause a sudden drop in a security. Often its an overreaction and the security will bounce back. But not always. Knowing the fundamental value of the security will help you know if a news-related dip is a buying opportunity or not.');
INSERT INTO forum (User_id, Title, Post) values (1, 'Risk vs. Reward', 'When you invest, you’ll often find a trade-off between risk and reward. Sometimes that trade-off is obvious. Sometimes it’s hidden.');
INSERT INTO forum (User_id, Title, Post) values (1, 'Title', 'Post');
SELECT * FROM forum;

