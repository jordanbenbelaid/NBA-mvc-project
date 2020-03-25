use master 

go

drop database if exists NbaDb

go

create database NbaDb

go

use NbaDb

go

CREATE TABLE Team (
TeamId int not null primary key identity,
TeamName varchar(255),
TeamChampionships varchar(255),
TeamFinaslAppearances varchar(255),
TeamConference varchar(255)
);

go

CREATE TABLE Player (
PlayerId int not null primary key identity,
TeamId int foreign key references Team(TeamId),
LastName varchar(30),
FirstName varchar(30),
Position varchar(255),
PlayerPointsScored int,
AllStarGames varchar(255),
VideoLink varchar(255),
PhotoLink varchar(255)
);

go

INSERT INTO Team (TeamName, TeamConference, TeamFinaslAppearances, TeamChampionships) Values
('Lakers', 'Western', '24', '16'),
('Celtics', 'Eastern', '21', '17');

go

INSERT INTO Player (FirstName, LastName, TeamId, Position, VideoLink, PhotoLink, PlayerPointsScored, AllStarGames) Values
('LeBron','James', 1, 'SF', 'https://www.youtube.com/embed/7Vre_nWbPxk', 'https://image.cnbcfm.com/api/v1/image/105642793-1545408067309gettyimages-1074484904.jpeg?v=1545408690&w=1400&h=950', 34087, '16'),
('Anthony', 'Davis', 1, 'PF','https://www.youtube.com/embed/TsLt0pwXs-s','https://cdn.sportspromedia.com/images/made/images/uploads/news/lakerscreditunion_630_354_80_s_c1.jpg', 12526, '7'),
('Rajon', 'Rondo', 1, 'PG','https://www.youtube.comembed/PXwmjabwZAU','https://images.spot.im/v1/production/d5gcba2sg7jjbzg57hcn',8909, '4'),
('Dwight', 'Howard', 1, 'C','https://www.youtube.com/embed/YPJ5NW87vkk','https://usatftw.files.wordpress.com/2019/11/ap-grizzlies-lakers-basketball.jpg?w=1000&h=600&crop=1', 18582, '8'),
('Danny', 'Green', 1, 'SG','https://www.youtube.com/embed/cmOfrGAfcgY','https://cdn.vox-cdn.com/thumbor/upQ_W-izMzHBK1oLMxko8rhh2c8=/0x0:2920x1999/1200x800/filters:focal(1216x490:1682x956)/cdn.vox-cdn.com/uploads/chorus_image/image/66413392/1208738044.jpg.0.jpg', 6077, '0'),
('Kemba', 'Walker', 2, 'PG','https://www.youtube.com/embed/FHjKEUyNwyU','https://images2.minutemediacdn.com/image/fetch/w_736,h_485,c_fill,g_auto,f_auto/https%3A%2F%2Fhardwoodhoudini.com%2Fwp-content%2Fuploads%2Fgetty-images%2F2017%2F07%2F1193420405-850x560.jpeg',13069, '4'),
('Jayson', 'Tatum', 2, 'PF','https://www.youtube.com/embed/6U262_a9aV4','https://usatcelticswire.files.wordpress.com/2019/12/27cd7db7-46f0-4efe-892a-28492d8f7548.jpeg?w=640',3745, '1'),
('Gordon', 'Hayward', 2, 'SF','https://www.youtube.com/embed/IPvUwrXHJjM','https://img.bleacherreport.net/img/images/photos/003/843/701/hi-res-976274adcce3d782079a3c89e477dda6_crop_north.jpg?h=533&w=800&q=70&crop_x=center&crop_y=top',9682, '1'),
('Enes', 'Kanter', 2, 'C','https://www.youtube.com/embed/szkp2c0eTME','https://storage.googleapis.com/afs-prod/media/5a6a540d128a424a94e350107e6799fe/3000.jpeg',7362, '0'),
('Marcus', 'Smart', 2, 'SG','https://www.youtube.com/embed/watch?v=kZXkc1COcXo','https://www.bostonherald.com/wp-content/uploads/2019/11/celticsms010-1.jpg',3888, '0');

go
