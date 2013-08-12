/*
Navicat SQLite Data Transfer

Source Server         : comicsGuess
Source Server Version : 30706
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30706
File Encoding         : 65001

Date: 2013-08-12 17:52:08
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for "main"."catalog"
-- ----------------------------
DROP TABLE "main"."catalog";
CREATE TABLE "catalog" (
"id"  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
"name"  VARCHAR(10) NOT NULL
);

-- ----------------------------
-- Table structure for "main"."comicsType"
-- ----------------------------
DROP TABLE "main"."comicsType";
CREATE TABLE "comicsType" (
"id"  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
"name"  VARCHAR(20) NOT NULL
);

-- ----------------------------
-- Table structure for "main"."sqlite_sequence"
-- ----------------------------
DROP TABLE "main"."sqlite_sequence";
CREATE TABLE sqlite_sequence(name,seq);

-- ----------------------------
-- Table structure for "main"."stage"
-- ----------------------------
DROP TABLE "main"."stage";
CREATE TABLE "stage" (
"id"  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
"name"  VARCHAR(10) NOT NULL,
"catalog"  INTEGER NOT NULL,
CONSTRAINT "fkey0" FOREIGN KEY ("catalog") REFERENCES "catalog" ("id")
);

-- ----------------------------
-- Table structure for "main"."subject"
-- ----------------------------
DROP TABLE "main"."subject";
CREATE TABLE "subject" (
"id"  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
"title"  VARCHAR(20),
"subjectType"  INTEGER,
"comicsType"  INTEGER,
"stage"  INTEGER NOT NULL,
"level"  INTEGER NOT NULL DEFAULT 0,
"remark"  VARCHAR(100),
"resImg"  VARCHAR(100),
"resText"  VARCHAR(300),
"resAudio"  VARCHAR(100),
"creatdate"  DATE,
"tip"  VARCHAR(100),
"selectors"  VARCHAR(100),
"answer"  VARCHAR(20) NOT NULL,
"sorter"  INTEGER NOT NULL DEFAULT 0,
"resolved"  BOOLEAN NOT NULL DEFAULT false,
CONSTRAINT "fkey0" FOREIGN KEY ("subjectType") REFERENCES "subjectType" ("id"),
CONSTRAINT "fkey1" FOREIGN KEY ("comicsType") REFERENCES "comicsType" ("id"),
CONSTRAINT "fkey2" FOREIGN KEY ("stage") REFERENCES "stage" ("id")
);

-- ----------------------------
-- Table structure for "main"."subjectType"
-- ----------------------------
DROP TABLE "main"."subjectType";
CREATE TABLE "subjectType" (
"id"  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
"name"  VARCHAR(10) NOT NULL
);

