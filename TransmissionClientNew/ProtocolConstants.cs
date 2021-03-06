// transmission-remote-dotnet
// http://code.google.com/p/transmission-remote-dotnet/
// Copyright (C) 2009 Alan F
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Text;

namespace TransmissionRemoteDotnet
{
    public class ProtocolConstants
    {
        public const short
            STATUS_NEW_STOPPED = 0,
            STATUS_NEW_CHECK_WAIT = 1,
            STATUS_NEW_CHECK = 2,
            STATUS_NEW_DOWNLOAD_WAIT = 3,
            STATUS_NEW_DOWNLOAD = 4,
            STATUS_NEW_SEED_WAIT = 5,
            STATUS_NEW_SEED = 6;

        public const short
            STATUS_OLD_CHECK_WAIT = 1,
            STATUS_OLD_CHECK = 2,
            STATUS_OLD_DOWNLOAD = 4,
            STATUS_OLD_SEED = 8,
            STATUS_OLD_STOPPED = 16;

        public static short
            STATUS_CHECK_WAIT = -1,
            STATUS_CHECK = -1,
            STATUS_DOWNLOAD_WAIT = -1,
            STATUS_DOWNLOAD = -1,
            STATUS_SEED_WAIT = -1,
            STATUS_SEED = -1,
            STATUS_STOPPED = -1;

        public static void SetupStatusValues(bool newstatus)
        {
            if (newstatus)
            {
                STATUS_CHECK_WAIT = STATUS_NEW_CHECK_WAIT;
                STATUS_CHECK = STATUS_NEW_CHECK;
                STATUS_DOWNLOAD_WAIT = STATUS_NEW_DOWNLOAD_WAIT;
                STATUS_DOWNLOAD = STATUS_NEW_DOWNLOAD;
                STATUS_SEED_WAIT = STATUS_NEW_SEED_WAIT;
                STATUS_SEED = STATUS_NEW_SEED;
                STATUS_STOPPED = STATUS_NEW_STOPPED;
            }
            else
            {
                STATUS_CHECK_WAIT = STATUS_OLD_CHECK_WAIT;
                STATUS_CHECK = STATUS_OLD_CHECK;
                STATUS_DOWNLOAD_WAIT = -1;
                STATUS_DOWNLOAD = STATUS_OLD_DOWNLOAD;
                STATUS_SEED_WAIT = -1;
                STATUS_SEED = STATUS_OLD_SEED;
                STATUS_STOPPED = STATUS_OLD_STOPPED;
            }
        }

        public const int
            BANDWIDTH_LOW = -1,
            BANDWIDTH_NORMAL = 0,
            BANDWIDTH_HIGH = 1;

        public const int
            TR_RATIOLIMIT_GLOBAL = 0, /* follow the global settings */
            TR_RATIOLIMIT_SINGLE = 1, /* override the global settings, seeding until a certain ratio */
            TR_RATIOLIMIT_UNLIMITED = 2;  /* override the global settings, seeding regardless of ratio */

        public const string
            KEY_TAG = "tag",
            KEY_METHOD = "method",
            KEY_IDS = "ids",
            KEY_ARGUMENTS = "arguments",
            KEY_FIELDS = "fields",
            KEY_TORRENTS = "torrents",
            METHOD_TORRENTGET = "torrent-get",
            METHOD_TORRENTSTART = "torrent-start",
            METHOD_TORRENTSTOP = "torrent-stop",
            METHOD_TORRENTSET = "torrent-set",
            METHOD_SESSIONGET = "session-get",
            METHOD_SESSIONSET = "session-set",
            METHOD_TORRENTREMOVE = "torrent-remove",
            METHOD_TORRENTVERIFY = "torrent-verify",
            METHOD_TORRENTADD = "torrent-add",
            METHOD_TORRENTREANNOUNCE = "torrent-reannounce",
            METHOD_SESSIONSTATS = "session-stats",
            METHOD_BLOCKLISTUPDATE = "blocklist-update",
            METHOD_PORT_TEST = "port-test",
            METHOD_TORRENT_SET_LOCATION = "torrent-set-location",
            FIELD_LOCATION = "location",
            FIELD_MOVE = "move",
            FIELD_PIECES = "pieces",
            FIELD_PIECECOUNT = "pieceCount",
            FIELD_PIECESIZE = "pieceSize",
//            FIELD_PIECECOMPLETE = "pieceComplete",
            FIELD_PEERSSENDINGTOUS = "peersSendingToUs",
            FIELD_PEERSGETTINGFROMUS = "peersGettingFromUs",
            FIELD_FLAGSTR = "flagStr",
            FIELD_HONORSSESSIONLIMITS = "honorsSessionLimits",
            FIELD_INCOMPLETE_DIR = "incomplete-dir",
            FIELD_INCOMPLETE_DIR_ENABLED = "incomplete-dir-enabled",
            FIELD_METAINFO = "metainfo",
            FIELD_CLIENTNAME = "clientName",
            FIELD_HAVEUNCHECKED = "haveUnchecked",
            FIELD_LEFTUNTILDONE = "leftUntilDone",
            FIELD_COMMENT = "comment",
            FIELD_NAME = "name",
            FIELD_RATETOCLIENT = "rateToClient",
            FIELD_BLOCKLISTSIZE = "blocklist-size",
            FIELD_RATETOPEER = "rateToPeer",
            FIELD_ERRORSTRING = "errorString",
            FIELD_PROGRESS = "progress",
            FIELD_FILENAME = "filename",
            FIELD_PAUSED = "paused",
            FIELD_ANNOUNCEURL = "announceURL",
            FIELD_ETA = "eta",
            FIELD_STATUS = "status",
            FIELD_BANDWIDTHPRIORITY = "bandwidthPriority",
            FIELD_RATEDOWNLOAD = "rateDownload",
            FIELD_RATEUPLOAD = "rateUpload",
            FIELD_TOTALSIZE = "totalSize",
            FIELD_HAVEVALID = "haveValid",
            FIELD_DOWNLOADEDEVER = "downloadedEver",
            FIELD_UPLOADEDEVER = "uploadedEver",
            FIELD_LEECHERS = "leechers",
            FIELD_SEEDERS = "seeders",
            FIELD_ADDEDDATE = "addedDate",
            FIELD_ACTIVITYDATE = "activityDate",
            FIELD_ID = "id",
            FIELD_FILES = "files",
            FIELD_PRIORITIES = "priorities",
            FIELD_WANTED = "wanted",
            FIELD_TRACKERS = "trackers",
            FIELD_TRACKERSTATS = "trackerStats",
            FIELD_IDENTIFIER = "id",
            FIELD_PEERS = "peers",
            FIELD_SIZEWHENDONE = "sizeWhenDone",
            FIELD_PEERLIMIT = "peer-limit",
            FIELD_PEERLIMITPERTORRENT = "peer-limit-per-torrent",
            FIELD_RENAME_PARTIAL_FILES = "rename-partial-files",
            FIELD_LENGTH = "length",
            FIELD_BYTESCOMPLETED = "bytesCompleted",
            FIELD_DELETELOCALDATA = "delete-local-data",
            FIELD_MAXCONNECTEDPEERS = "maxConnectedPeers",
            FIELD_CREATOR = "creator",
            FIELD_SWARMSPEED = "swarmSpeed",
            FIELD_DATECREATED = "dateCreated",
            FIELD_HASHSTRING = "hashString",
            FIELD_DOWNLOADDIR = "downloadDir",
            FIELD_RECHECKPROGRESS = "recheckProgress",
            FIELD_SEEDRATIOLIMIT = "seedRatioLimit",
            FIELD_SEEDRATIOMODE = "seedRatioMode",
            FIELD_SEEDRATIOLIMITED = "seedRatioLimited", // session-set/get
            VALUE_RECENTLY_ACTIVE = "recently-active",
            /* BEGIN CONFUSION */
            FIELD_DOWNLOADLIMITMODE = "downloadLimitMode", // DEPRECATED
            FIELD_UPLOADLIMITMODE = "uploadLimitMode", // DEPRECATED
            FIELD_SPEEDLIMITDOWNENABLED = "speed-limit-down-enabled", // ALSO DEPRECATED
            FIELD_SPEEDLIMITUPENABLED = "speed-limit-up-enabled", // ALSO DEPRECATED
            FIELD_SPEEDLIMITDOWN = "speed-limit-down", // ALSO DEPRECATED
            FIELD_SPEEDLIMITUP = "speed-limit-up", // ALSO DEPRECATED
            FIELD_UPLOADLIMITED = "uploadLimited",
            FIELD_DOWNLOADLIMITED = "downloadLimited",
            FIELD_UPLOADLIMIT = "uploadLimit",
            FIELD_DOWNLOADLIMIT = "downloadLimit",
            FIELD_PORT_IS_OPEN = "port-is-open",
            // tracker stats
            TRACKERSTAT_SEEDERCOUNT = "seederCount",
            TRACKERSTAT_LEECHERCOUNT = "leecherCount",
            // settings
            FIELD_PORTFORWARDINGENABLED = "port-forwarding-enabled",
            FIELD_ENCRYPTION = "encryption",
            FIELD_ALTSPEEDTIMEENABLED = "alt-speed-time-enabled",
            FIELD_ALTSPEEDTIMEBEGIN = "alt-speed-time-begin",
            FIELD_ALTSPEEDTIMEEND = "alt-speed-time-end",
            FIELD_BLOCKLISTENABLED = "blocklist-enabled",
            FIELD_ALTSPEEDENABLED = "alt-speed-enabled",
            FIELD_ALTSPEEDDOWN = "alt-speed-down",
            FIELD_ALTSPEEDUP = "alt-speed-up",
            FIELD_LPDENABLED = "lpd-enabled",
            FIELD_DHTENABLED = "dht-enabled",
            FIELD_PEERLIMITGLOBAL = "peer-limit-global",
            FIELD_PEXENABLED = "pex-enabled",
            FIELD_PEXALLOWED = "pex-allowed",
            VALUE_PREFERRED = "preferred",
            VALUE_TOLERATED = "tolerated",
            VALUE_REQUIRED = "required",
            FIELD_DONEDATE = "doneDate",
            PRIORITY_HIGH = "priority-high",
            PRIORITY_NORMAL = "priority-normal",
            PRIORITY_LOW = "priority-low",
            FILES_WANTED = "files-wanted",
            FILES_UNWANTED = "files-unwanted",
            ADDRESS = "address",
            TIER = "tier",
            ANNOUNCE = "announce",
            SCRAPE = "scrape",
            DOWNLOAD_DIR = "download-dir";
    }
}
