/*
Navicat SQLite Data Transfer

Source Server         : CGDatabaseConn
Source Server Version : 30706
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30706
File Encoding         : 65001

Date: 2013-08-15 11:55:04
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for "main"."catalog"
-- ----------------------------
DROP TABLE "main"."catalog";
CREATE TABLE "main"."catalog" (
"id"  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
"name"  VARCHAR(10) NOT NULL
);

-- ----------------------------
-- Records of catalog
-- ----------------------------
INSERT INTO "main"."catalog" VALUES (1, '一周目');
INSERT INTO "main"."catalog" VALUES (2, '二周目');
INSERT INTO "main"."catalog" VALUES (3, '三周目');

-- ----------------------------
-- Table structure for "main"."comicsType"
-- ----------------------------
DROP TABLE "main"."comicsType";
CREATE TABLE "comicsType" (
"id"  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
"name"  VARCHAR(20) NOT NULL
);

-- ----------------------------
-- Records of comicsType
-- ----------------------------
INSERT INTO "main"."comicsType" VALUES (1, '热血');
INSERT INTO "main"."comicsType" VALUES (2, '科幻');
INSERT INTO "main"."comicsType" VALUES (3, '神魔');
INSERT INTO "main"."comicsType" VALUES (4, '机战');
INSERT INTO "main"."comicsType" VALUES (5, '竞技');
INSERT INTO "main"."comicsType" VALUES (6, '格斗');
INSERT INTO "main"."comicsType" VALUES (7, '恋爱');
INSERT INTO "main"."comicsType" VALUES (8, '励志');
INSERT INTO "main"."comicsType" VALUES (9, '搞笑');
INSERT INTO "main"."comicsType" VALUES (10, '冒险');
INSERT INTO "main"."comicsType" VALUES (11, '刑侦');
INSERT INTO "main"."comicsType" VALUES (12, '历史');
INSERT INTO "main"."comicsType" VALUES (13, '神话');
INSERT INTO "main"."comicsType" VALUES (14, '宠物');
INSERT INTO "main"."comicsType" VALUES (15, '悬疑');
INSERT INTO "main"."comicsType" VALUES (16, '幻想');
INSERT INTO "main"."comicsType" VALUES (17, '友情');
INSERT INTO "main"."comicsType" VALUES (18, '运动');
INSERT INTO "main"."comicsType" VALUES (19, '美女');
INSERT INTO "main"."comicsType" VALUES (20, '战争');
INSERT INTO "main"."comicsType" VALUES (21, '校园');
INSERT INTO "main"."comicsType" VALUES (22, '推理');
INSERT INTO "main"."comicsType" VALUES (23, '吸血鬼');
INSERT INTO "main"."comicsType" VALUES (24, '忍者');

-- ----------------------------
-- Table structure for "main"."stage"
-- ----------------------------
DROP TABLE "main"."stage";
CREATE TABLE "main"."stage" (
"id"  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
"name"  VARCHAR(10) NOT NULL,
"catalog"  INTEGER NOT NULL,
"stageType"  INTEGER NOT NULL,
"unlocked"  BOOLEAN NOT NULL DEFAULT false,
"nearSubject"  INTEGER,
CONSTRAINT "fkey0" FOREIGN KEY ("catalog") REFERENCES "catalog" ("id"),
FOREIGN KEY ("stageType") REFERENCES "stageType" ("id"),
FOREIGN KEY ("nearSubject") REFERENCES "subject" ("id")
);

-- ----------------------------
-- Records of stage
-- ----------------------------

-- ----------------------------
-- Table structure for "main"."stageType"
-- ----------------------------
DROP TABLE "main"."stageType";
CREATE TABLE "main"."stageType" (
"id"  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
"name"  varchar(10) NOT NULL
);

-- ----------------------------
-- Records of stageType
-- ----------------------------
INSERT INTO "main"."stageType" VALUES (1, '主线关卡');
INSERT INTO "main"."stageType" VALUES (2, '主题关卡');

-- ----------------------------
-- Table structure for "main"."subject"
-- ----------------------------
DROP TABLE "main"."subject";
CREATE TABLE "main"."subject" (
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
-- Records of subject
-- ----------------------------

-- ----------------------------
-- Table structure for "main"."subjectType"
-- ----------------------------
DROP TABLE "main"."subjectType";
CREATE TABLE "main"."subjectType" (
"id"  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
"name"  VARCHAR(10) NOT NULL
);

-- ----------------------------
-- Records of subjectType
-- ----------------------------
INSERT INTO "main"."subjectType" VALUES (1, '人物角色');
INSERT INTO "main"."subjectType" VALUES (2, '动漫名称');
INSERT INTO "main"."subjectType" VALUES (3, '人物声优');
INSERT INTO "main"."subjectType" VALUES (4, '动漫作者');
INSERT INTO "main"."subjectType" VALUES (5, '物品名称');
INSERT INTO "main"."subjectType" VALUES (6, '绝招名称');
