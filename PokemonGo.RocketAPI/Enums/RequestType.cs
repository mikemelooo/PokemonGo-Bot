﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo.RocketAPI.Enums
{
    public enum RequestType
    {
        METHOD_UNSET = 0,
        PLAYER_UPDATE = 1,
        GET_PLAYER = 2,
        GET_INVENTORY = 4,
        DOWNLOAD_SETTINGS = 5,
        DOWNLOAD_ITEM_TEMPLATES = 6,
        DOWNLOAD_REMOTE_CONFIG_VERSION = 7,
        FORT_SEARCH = 101,
        ENCOUNTER = 102,
        CATCH_POKEMON = 103,
        FORT_DETAILS = 104,
        ITEM_USE = 105,
        GET_MAP_OBJECTS = 106,
        FORT_DEPLOY_POKEMON = 110,
        FORT_RECALL_POKEMON = 111,
        RELEASE_POKEMON = 112,
        USE_ITEM_POTION = 113,
        USE_ITEM_CAPTURE = 114,
        USE_ITEM_FLEE = 115,
        USE_ITEM_REVIVE = 116,
        TRADE_SEARCH = 117,
        TRADE_OFFER = 118,
        TRADE_RESPONSE = 119,
        TRADE_RESULT = 120,
        GET_PLAYER_PROFILE = 121,
        GET_ITEM_PACK = 122,
        BUY_ITEM_PACK = 123,
        BUY_GEM_PACK = 124,
        EVOLVE_POKEMON = 125,
        GET_HATCHED_OBJECTS = 126,
        ENCOUNTER_TUTORIAL_COMPLETE = 127,
        LEVEL_UP_REWARDS = 128,
        CHECK_AWARDED_BADGES = 129,
        USE_ITEM_GYM = 133,
        GET_GYM_DETAILS = 134,
        START_GYM_BATTLE = 135,
        ATTACK_GYM = 136,
        RECYCLE_INVENTORY_ITEM = 137,
        COLLECT_DAILY_BONUS = 138,
        USE_ITEM_XP_BOOST = 139,
        USE_ITEM_EGG_INCUBATOR = 140,
        USE_INCENSE = 141,
        GET_INCENSE_POKEMON = 142,
        INCENSE_ENCOUNTER = 143,
        ADD_FORT_MODIFIER = 144,
        DISK_ENCOUNTER = 145,
        COLLECT_DAILY_DEFENDER_BONUS = 146,
        UPGRADE_POKEMON = 147,
        SET_FAVORITE_POKEMON = 148,
        NICKNAME_POKEMON = 149,
        EQUIP_BADGE = 150,
        SET_CONTACT_SETTINGS = 151,
        GET_ASSET_DIGEST = 300,
        GET_DOWNLOAD_URLS = 301,
        GET_SUGGESTED_CODENAMES = 401,
        CHECK_CODENAME_AVAILABLE = 402,
        CLAIM_CODENAME = 403,
        SET_AVATAR = 404,
        SET_PLAYER_TEAM = 405,
        MARK_TUTORIAL_COMPLETE = 406,
        LOAD_SPAWN_POINTS = 500,
        ECHO = 666,
        DEBUG_UPDATE_INVENTORY = 700,
        DEBUG_DELETE_PLAYER = 701,
        SFIDA_REGISTRATION = 800,
        SFIDA_ACTION_LOG = 801,
        SFIDA_CERTIFICATION = 802,
        SFIDA_UPDATE = 803,
        SFIDA_ACTION = 804,
        SFIDA_DOWSER = 805,
        SFIDA_CAPTURE = 806,
    }
}
