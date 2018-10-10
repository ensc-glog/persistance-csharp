create database if not exists persons character set utf8 collate utf8_unicode_ci;
use prospects;

grant all privileges on persons.* to 'persons_user'@'localhost' identified by 'secret';