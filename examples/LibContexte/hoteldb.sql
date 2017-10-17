
create database if not exists hotelDB character set utf8 collate utf8_unicode_ci;
use hotelDB;

grant all privileges on hotelDB.* to 'utilHotel'@'localhost' identified by 'secret';

drop table if exists room;
drop table if exists hotel;

create table hotel (
    hotel_id integer not null primary key auto_increment,
    hotel_name varchar(100) not null
);

create table room (
    room_id integer not null primary key auto_increment,
    room_number integer not null,
    room_floor integer not null,
    room_empty boolean not null default true,
	hotel_id integer not null,
	foreign key (hotel_id) references hotel(hotel_id)
);

insert into hotel values(1, "Chelsea Hotel");

insert into room values(1, 1, 0, 1, 1);
insert into room values(2, 2, 1, 1, 1);
insert into room values(3, 3, 1, 0, 1);