/*
Navicat SQLite Data Transfer

Source Server         : ComicsGuessTest
Source Server Version : 30706
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30706
File Encoding         : 65001

Date: 2013-09-26 11:15:51
*/

PRAGMA foreign_keys = OFF;

--  ---------------------
--  如果DB中已有表，打开下面的注释语句
--  ----------------------
--UPDATE "main"."stage" SET nearSubject=NULL;

DROP TABLE IF EXISTS "main"."subject";
DROP TABLE IF EXISTS "main"."stage";
DROP TABLE IF EXISTS "main"."catalog";
DROP TABLE IF EXISTS "main"."comicsType";
DROP TABLE IF EXISTS "main"."stageType";
DROP TABLE IF EXISTS "main"."subjectType";

CREATE TABLE "catalog" (
"id"  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
"name"  VARCHAR(10) NOT NULL
);

CREATE TABLE "comicsType" (
"id"  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
"name"  VARCHAR(20) NOT NULL
);

CREATE TABLE "stage" (
"id"  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
"name"  VARCHAR(10) NOT NULL,
"catalog"  INTEGER NOT NULL,
"stageType"  INTEGER NOT NULL,
"unlocked"  BOOLEAN NOT NULL DEFAULT false,
"nearSubject"  INTEGER,
CONSTRAINT "fkey0" FOREIGN KEY ("catalog") REFERENCES "catalog" ("id"),
CONSTRAINT "fkey1" FOREIGN KEY ("stageType") REFERENCES "stageType" ("id"),
CONSTRAINT "fkey2" FOREIGN KEY ("nearSubject") REFERENCES "subject" ("id")
);

CREATE TABLE "stageType" (
"id"  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
"name"  varchar(10) NOT NULL
);

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
CONSTRAINT "fkey2" FOREIGN KEY ("stage") REFERENCES "stage" ("id") DEFERRABLE INITIALLY DEFERRED
);

CREATE TABLE "subjectType" (
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
-- Records of stageType
-- ----------------------------
INSERT INTO "main"."stageType" VALUES (1, '主线关卡');
INSERT INTO "main"."stageType" VALUES (2, '主题关卡');


-- ----------------------------
-- Records of subjectType
-- ----------------------------
INSERT INTO "main"."subjectType" VALUES (1, '人物角色');
INSERT INTO "main"."subjectType" VALUES (2, '动漫名称');
INSERT INTO "main"."subjectType" VALUES (3, '人物声优');
INSERT INTO "main"."subjectType" VALUES (4, '动漫作者');
INSERT INTO "main"."subjectType" VALUES (5, '物品名称');
INSERT INTO "main"."subjectType" VALUES (6, '绝招名称');



-- ----------------------------
-- Records of stage
-- ----------------------------
INSERT INTO "main"."stage" VALUES (1, '主线关卡1', 1, 1, 'true', null);
INSERT INTO "main"."stage" VALUES (2, '火影忍者', 1, 2, 'false', null);
INSERT INTO "main"."stage" VALUES (3, '海贼王', 1, 2, 'false', null);
INSERT INTO "main"."stage" VALUES (4, '圣斗士星矢', 1, 2, 'false', null);



-- ----------------------------
-- Records of subject
-- ----------------------------
INSERT INTO "main"."subject" VALUES (1, '恶魔奶爸', 2, null, 1, 1, null, null, '【作品提示】 
1、男主是个不良少年，却自认为是“英俊潇洒、心地善良的少年” 
2、男主在河边捡到一个婴儿 
3、婴儿一直是全裸 ', null, null, '第一个字：恶', null, '恶魔奶爸', 0, 'false');
INSERT INTO "main"."subject" VALUES (2, '杀生丸', 1, null, 1, 2, null, null, '【人物提示】 
1、银白色长发 
2、有一把只能救人的刀 
3、迷人的扑克脸', null, null, '第一个字：杀', null, '杀生丸', 0, 'fasle');
INSERT INTO "main"."subject" VALUES (3, '滑头鬼之孙', 2, null, 1, 3, null, null, '【作品提示】 
1.爷孙三代 
2.阴阳师 
3.动画目前进入高潮', null, null, '第一个字：滑', null, '滑头鬼之孙', 0, 'false');
INSERT INTO "main"."subject" VALUES (4, '青蛙军曹', 2, null, 1, 4, null, null, '【作品提示】 
1、侵略地球 
2、被地球人欺负 
3、萌 ', null, null, '第一个字：青', null, '青蛙军曹', 0, 'false');
INSERT INTO "main"."subject" VALUES (5, '丁次', 1, null, 1, 5, null, null, '【人物提示】 
1、“胖……” 
2、“××战车！” 
3、“啊——————————” 

丁次。', null, null, '第一个字：丁', null, '丁次', 0, 'false');
INSERT INTO "main"."subject" VALUES (6, '未来日记', 2, null, 1, 0, null, null, '【作品提示】 
1、手機 
2、病嬌娘 
3、粉紅切開都是黑。', null, null, '第一个字：未', null, '未来日记', 0, 'false');
INSERT INTO "main"."subject" VALUES (7, '樱木花道', 1, null, 1, 1, null, null, '【人物提示】 
失恋五十次..', null, null, '第一个字：樱', null, '樱木花道', 0, 'false');
INSERT INTO "main"."subject" VALUES (8, '小阎王', 1, null, 1, 2, null, null, '【人物提示】 
1.地狱头 
2.奶嘴 
3.变身', null, null, '第二个字：阎', null, '小阎王', 0, 'false');
INSERT INTO "main"."subject" VALUES (9, '圣子到', 2, null, 1, 3, null, null, '【作品提示】 
1.最强不良少年 
2.铁板烧 
3.上帝之子（疑似） ', null, null, '第一个字：圣', null, '圣子到', 0, 'false');
INSERT INTO "main"."subject" VALUES (10, '芥辺', 1, null, 1, 4, null, null, '【人物提示】 
1、无眉 
2、欺负恶魔 
3、不择手段 ', null, null, '第一个字：芥', null, '芥辺', 0, 'false');
INSERT INTO "main"."subject" VALUES (11, '索隆', 1, null, 1, 5, null, '1/gc_img_11.jpg', null, null, null, '第一个字：索', null, '索隆', 0, 'false');
INSERT INTO "main"."subject" VALUES (12, '草摩由希(水果篮子)', 1, null, 1, 0, null, '1/gc_img_12.jpg', null, null, null, '第一个字：草', null, '草摩由希', 0, 'false');
INSERT INTO "main"."subject" VALUES (13, '一平(家庭教师)', 1, null, 1, 1, null, '1/gc_img_13.jpg', null, null, null, '第二个字：平', null, '一平', 0, 'false');
INSERT INTO "main"."subject" VALUES (14, '纳兹', 1, null, 1, 2, null, '1/gc_img_14.jpg', null, null, null, '第一个字：纳', null, '纳兹', 0, 'false');
INSERT INTO "main"."subject" VALUES (15, '黑崎一护', 1, null, 1, 3, null, '1/gc_img_15.jpg', null, null, null, '第一个字：黑', null, '黑崎一护', 0, 'false');
INSERT INTO "main"."subject" VALUES (16, '柯南', 1, null, 1, 4, null, '1/gc_img_16.jpg', null, null, null, '第一个字：柯', null, '柯南', 0, 'false');
INSERT INTO "main"."subject" VALUES (17, '七龙珠', 2, null, 1, 5, null, '1/gc_img_17.jpg', null, null, null, '第一个字：七', null, '七龙珠', 0, 'false');
INSERT INTO "main"."subject" VALUES (18, '大力水手', 2, null, 1, 0, null, '1/gc_img_18.jpg', null, null, null, '第一个字：大', null, '大力水手', 0, 'false');
INSERT INTO "main"."subject" VALUES (19, '阿童木', 1, null, 1, 1, null, '1/gc_img_19.jpg', null, null, null, '第一个字：阿', null, '阿童木', 0, 'false');
INSERT INTO "main"."subject" VALUES (20, '忍者神龟', 2, null, 1, 2, null, '1/gc_img_20.jpg', null, null, null, '第一个字：忍', null, '忍者神龟', 0, 'false');
INSERT INTO "main"."subject" VALUES (21, 'IO博士', 2, null, 1, 3, null, null, '耸人听闻！近视少女人头分离！', null, null, '第一个字：I', null, 'IO博士', 0, 'false');
INSERT INTO "main"."subject" VALUES (22, '圣斗士星矢', 2, null, 1, 4, null, null, '销魂！白衣女子玩弄五男生一生!', null, null, '第一个字：圣', null, '圣斗士星矢', 0, 'false');
INSERT INTO "main"."subject" VALUES (23, '机器猫', 2, null, 1, 5, null, null, '自强不息！无指少年科技创新搞发明', null, null, '第一个字：机', null, '机器猫', 0, 'false');
INSERT INTO "main"."subject" VALUES (24, '夏目友人帐', 2, null, 1, 0, null, null, '1.妖怪 2.治愈系 3.卖萌老师', null, null, '第一个字：夏', null, '夏目友人帐', 0, 'false');
INSERT INTO "main"."subject" VALUES (25, '小智', 1, null, 1, 1, null, '1/gc_img_25.jpg', null, null, null, '第二个字：智', null, '小智', 0, 'false');
INSERT INTO "main"."subject" VALUES (26, '我爱罗', 1, null, 1, 2, null, '1/gc_img_26.jpg', null, null, null, '第一个字：我', null, '我爱罗', 0, 'false');
INSERT INTO "main"."subject" VALUES (27, '星矢', 1, null, 1, 3, null, '1/gc_img_27.jpg', null, null, null, '第一个字：星', null, '星矢', 0, 'false');
INSERT INTO "main"."subject" VALUES (28, '大雄', 1, null, 1, 4, null, '1/gc_img_28.jpg', null, null, null, '第一个字：大', null, '大雄', 0, 'false');
INSERT INTO "main"."subject" VALUES (29, '葫芦娃', 2, null, 1, 5, null, '1/gc_img_29.jpg', null, null, null, '第一个字：葫', null, '葫芦娃', 0, 'false');
INSERT INTO "main"."subject" VALUES (30, '夏娜', 1, null, 1, 0, null, '1/gc_img_30.jpg', null, null, null, '第一个字：夏', null, '夏娜', 0, 'false');
INSERT INTO "main"."subject" VALUES (31, '水木', 1, null, 2, 1, null, null, '鸣人被谁蛊惑去偷封印之书', null, null, '第一个字：水', null, '水木', 0, 'false');
INSERT INTO "main"."subject" VALUES (32, '波风水门', 1, null, 2, 2, null, null, '鸣人的父亲是谁', null, null, '第一个字：波', null, '波风水门', 0, 'false');
INSERT INTO "main"."subject" VALUES (33, '卡卡西', 1, null, 2, 3, null, '1/gc_img_33.jpg', null, null, null, '第一个字：卡', null, '卡卡西', 0, 'false');
INSERT INTO "main"."subject" VALUES (34, '鹿丸', 1, null, 2, 4, null, '1/gc_img_34.jpg', null, null, null, '第一个字：鹿', null, '鹿丸', 0, 'false');
INSERT INTO "main"."subject" VALUES (35, '宇智波佐助', 1, null, 2, 5, null, '1/gc_img_35.jpg', null, null, null, '第一个字：宇', null, '宇智波佐助', 0, 'false');
INSERT INTO "main"."subject" VALUES (36, '李洛克', 1, null, 2, 0, null, '1/gc_img_36.jpg', null, null, null, '第一个字：李', null, '李洛克', 0, 'false');
INSERT INTO "main"."subject" VALUES (37, '宇智波鼬', 1, null, 2, 1, null, '1/gc_img_37.jpg', null, null, null, '第一个字：宇', null, '宇智波鼬', 0, 'false');
INSERT INTO "main"."subject" VALUES (38, '自来也', 1, null, 2, 2, null, '1/gc_img_38.jpg', null, null, null, '第一个字：自', null, '自来也', 0, 'false');
INSERT INTO "main"."subject" VALUES (39, '春野樱', 1, null, 2, 3, null, '1/gc_img_39.jpg', null, null, null, '第一个字：春', null, '春野樱', 0, 'false');
INSERT INTO "main"."subject" VALUES (40, '日向宁次', 1, null, 2, 5, null, '1/gc_img_40.jpg', null, null, null, '第一个字：日', null, '日向宁次', 0, 'false');

--  UPDATE stage's nearSubject DATA
UPDATE "main"."stage" SET nearSubject=5 WHERE id=2;
UPDATE "main"."stage" SET nearSubject=11 WHERE id=3;
UPDATE "main"."stage" SET nearSubject=22 WHERE id=4;
