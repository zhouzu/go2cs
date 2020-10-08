// Copyright 2018 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package runtime -- go2cs converted at 2020 October 08 03:23:35 UTC
// import "runtime" ==> using runtime = go.runtime_package
// Original source: C:\Go\src\runtime\sigtab_aix.go

using static go.builtin;

namespace go
{
    public static partial class runtime_package
    {
        private static array<sigTabT> sigtable = new array<sigTabT>(InitKeyedValues<sigTabT>((0, {0,"SIGNONE: no trap"}), (_SIGHUP, {_SigNotify+_SigKill,"SIGHUP: terminal line hangup"}), (_SIGINT, {_SigNotify+_SigKill,"SIGINT: interrupt"}), (_SIGQUIT, {_SigNotify+_SigThrow,"SIGQUIT: quit"}), (_SIGILL, {_SigThrow+_SigUnblock,"SIGILL: illegal instruction"}), (_SIGTRAP, {_SigThrow+_SigUnblock,"SIGTRAP: trace trap"}), (_SIGABRT, {_SigNotify+_SigThrow,"SIGABRT: abort"}), (_SIGBUS, {_SigPanic+_SigUnblock,"SIGBUS: bus error"}), (_SIGFPE, {_SigPanic+_SigUnblock,"SIGFPE: floating-point exception"}), (_SIGKILL, {0,"SIGKILL: kill"}), (_SIGUSR1, {_SigNotify,"SIGUSR1: user-defined signal 1"}), (_SIGSEGV, {_SigPanic+_SigUnblock,"SIGSEGV: segmentation violation"}), (_SIGUSR2, {_SigNotify,"SIGUSR2: user-defined signal 2"}), (_SIGPIPE, {_SigNotify,"SIGPIPE: write to broken pipe"}), (_SIGALRM, {_SigNotify,"SIGALRM: alarm clock"}), (_SIGTERM, {_SigNotify+_SigKill,"SIGTERM: termination"}), (_SIGCHLD, {_SigNotify+_SigUnblock,"SIGCHLD: child status has changed"}), (_SIGCONT, {_SigNotify+_SigDefault,"SIGCONT: continue"}), (_SIGSTOP, {0,"SIGSTOP: stop"}), (_SIGTSTP, {_SigNotify+_SigDefault,"SIGTSTP: keyboard stop"}), (_SIGTTIN, {_SigNotify+_SigDefault,"SIGTTIN: background read from tty"}), (_SIGTTOU, {_SigNotify+_SigDefault,"SIGTTOU: background write to tty"}), (_SIGURG, {_SigNotify,"SIGURG: urgent condition on socket"}), (_SIGXCPU, {_SigNotify,"SIGXCPU: cpu limit exceeded"}), (_SIGXFSZ, {_SigNotify,"SIGXFSZ: file size limit exceeded"}), (_SIGVTALRM, {_SigNotify,"SIGVTALRM: virtual alarm clock"}), (_SIGPROF, {_SigNotify+_SigUnblock,"SIGPROF: profiling alarm clock"}), (_SIGWINCH, {_SigNotify,"SIGWINCH: window size change"}), (_SIGSYS, {_SigThrow,"SIGSYS: bad system call"}), (_SIGIO, {_SigNotify,"SIGIO: i/o now possible"}), (_SIGPWR, {_SigNotify,"SIGPWR: power failure restart"}), (_SIGEMT, {_SigThrow,"SIGEMT: emulate instruction executed"}), (_SIGWAITING, {0,"SIGWAITING: reserved signal no longer used by"}), (26, {_SigNotify,"signal 26"}), (27, {_SigNotify,"signal 27"}), (33, {_SigNotify,"signal 33"}), (35, {_SigNotify,"signal 35"}), (36, {_SigNotify,"signal 36"}), (37, {_SigNotify,"signal 37"}), (38, {_SigNotify,"signal 38"}), (40, {_SigNotify,"signal 40"}), (41, {_SigNotify,"signal 41"}), (42, {_SigNotify,"signal 42"}), (43, {_SigNotify,"signal 43"}), (44, {_SigNotify,"signal 44"}), (45, {_SigNotify,"signal 45"}), (46, {_SigNotify,"signal 46"}), (47, {_SigNotify,"signal 47"}), (48, {_SigNotify,"signal 48"}), (49, {_SigNotify,"signal 49"}), (50, {_SigNotify,"signal 50"}), (51, {_SigNotify,"signal 51"}), (52, {_SigNotify,"signal 52"}), (53, {_SigNotify,"signal 53"}), (54, {_SigNotify,"signal 54"}), (55, {_SigNotify,"signal 55"}), (56, {_SigNotify,"signal 56"}), (57, {_SigNotify,"signal 57"}), (58, {_SigNotify,"signal 58"}), (59, {_SigNotify,"signal 59"}), (60, {_SigNotify,"signal 60"}), (61, {_SigNotify,"signal 61"}), (62, {_SigNotify,"signal 62"}), (63, {_SigNotify,"signal 63"}), (64, {_SigNotify,"signal 64"}), (65, {_SigNotify,"signal 65"}), (66, {_SigNotify,"signal 66"}), (67, {_SigNotify,"signal 67"}), (68, {_SigNotify,"signal 68"}), (69, {_SigNotify,"signal 69"}), (70, {_SigNotify,"signal 70"}), (71, {_SigNotify,"signal 71"}), (72, {_SigNotify,"signal 72"}), (73, {_SigNotify,"signal 73"}), (74, {_SigNotify,"signal 74"}), (75, {_SigNotify,"signal 75"}), (76, {_SigNotify,"signal 76"}), (77, {_SigNotify,"signal 77"}), (78, {_SigNotify,"signal 78"}), (79, {_SigNotify,"signal 79"}), (80, {_SigNotify,"signal 80"}), (81, {_SigNotify,"signal 81"}), (82, {_SigNotify,"signal 82"}), (83, {_SigNotify,"signal 83"}), (84, {_SigNotify,"signal 84"}), (85, {_SigNotify,"signal 85"}), (86, {_SigNotify,"signal 86"}), (87, {_SigNotify,"signal 87"}), (88, {_SigNotify,"signal 88"}), (89, {_SigNotify,"signal 89"}), (90, {_SigNotify,"signal 90"}), (91, {_SigNotify,"signal 91"}), (92, {_SigNotify,"signal 92"}), (93, {_SigNotify,"signal 93"}), (94, {_SigNotify,"signal 94"}), (95, {_SigNotify,"signal 95"}), (96, {_SigNotify,"signal 96"}), (97, {_SigNotify,"signal 97"}), (98, {_SigNotify,"signal 98"}), (99, {_SigNotify,"signal 99"}), (100, {_SigNotify,"signal 100"}), (101, {_SigNotify,"signal 101"}), (102, {_SigNotify,"signal 102"}), (103, {_SigNotify,"signal 103"}), (104, {_SigNotify,"signal 104"}), (105, {_SigNotify,"signal 105"}), (106, {_SigNotify,"signal 106"}), (107, {_SigNotify,"signal 107"}), (108, {_SigNotify,"signal 108"}), (109, {_SigNotify,"signal 109"}), (110, {_SigNotify,"signal 110"}), (111, {_SigNotify,"signal 111"}), (112, {_SigNotify,"signal 112"}), (113, {_SigNotify,"signal 113"}), (114, {_SigNotify,"signal 114"}), (115, {_SigNotify,"signal 115"}), (116, {_SigNotify,"signal 116"}), (117, {_SigNotify,"signal 117"}), (118, {_SigNotify,"signal 118"}), (119, {_SigNotify,"signal 119"}), (120, {_SigNotify,"signal 120"}), (121, {_SigNotify,"signal 121"}), (122, {_SigNotify,"signal 122"}), (123, {_SigNotify,"signal 123"}), (124, {_SigNotify,"signal 124"}), (125, {_SigNotify,"signal 125"}), (126, {_SigNotify,"signal 126"}), (127, {_SigNotify,"signal 127"}), (128, {_SigNotify,"signal 128"}), (129, {_SigNotify,"signal 129"}), (130, {_SigNotify,"signal 130"}), (131, {_SigNotify,"signal 131"}), (132, {_SigNotify,"signal 132"}), (133, {_SigNotify,"signal 133"}), (134, {_SigNotify,"signal 134"}), (135, {_SigNotify,"signal 135"}), (136, {_SigNotify,"signal 136"}), (137, {_SigNotify,"signal 137"}), (138, {_SigNotify,"signal 138"}), (139, {_SigNotify,"signal 139"}), (140, {_SigNotify,"signal 140"}), (141, {_SigNotify,"signal 141"}), (142, {_SigNotify,"signal 142"}), (143, {_SigNotify,"signal 143"}), (144, {_SigNotify,"signal 144"}), (145, {_SigNotify,"signal 145"}), (146, {_SigNotify,"signal 146"}), (147, {_SigNotify,"signal 147"}), (148, {_SigNotify,"signal 148"}), (149, {_SigNotify,"signal 149"}), (150, {_SigNotify,"signal 150"}), (151, {_SigNotify,"signal 151"}), (152, {_SigNotify,"signal 152"}), (153, {_SigNotify,"signal 153"}), (154, {_SigNotify,"signal 154"}), (155, {_SigNotify,"signal 155"}), (156, {_SigNotify,"signal 156"}), (157, {_SigNotify,"signal 157"}), (158, {_SigNotify,"signal 158"}), (159, {_SigNotify,"signal 159"}), (160, {_SigNotify,"signal 160"}), (161, {_SigNotify,"signal 161"}), (162, {_SigNotify,"signal 162"}), (163, {_SigNotify,"signal 163"}), (164, {_SigNotify,"signal 164"}), (165, {_SigNotify,"signal 165"}), (166, {_SigNotify,"signal 166"}), (167, {_SigNotify,"signal 167"}), (168, {_SigNotify,"signal 168"}), (169, {_SigNotify,"signal 169"}), (170, {_SigNotify,"signal 170"}), (171, {_SigNotify,"signal 171"}), (172, {_SigNotify,"signal 172"}), (173, {_SigNotify,"signal 173"}), (174, {_SigNotify,"signal 174"}), (175, {_SigNotify,"signal 175"}), (176, {_SigNotify,"signal 176"}), (177, {_SigNotify,"signal 177"}), (178, {_SigNotify,"signal 178"}), (179, {_SigNotify,"signal 179"}), (180, {_SigNotify,"signal 180"}), (181, {_SigNotify,"signal 181"}), (182, {_SigNotify,"signal 182"}), (183, {_SigNotify,"signal 183"}), (184, {_SigNotify,"signal 184"}), (185, {_SigNotify,"signal 185"}), (186, {_SigNotify,"signal 186"}), (187, {_SigNotify,"signal 187"}), (188, {_SigNotify,"signal 188"}), (189, {_SigNotify,"signal 189"}), (190, {_SigNotify,"signal 190"}), (191, {_SigNotify,"signal 191"}), (192, {_SigNotify,"signal 192"}), (193, {_SigNotify,"signal 193"}), (194, {_SigNotify,"signal 194"}), (195, {_SigNotify,"signal 195"}), (196, {_SigNotify,"signal 196"}), (197, {_SigNotify,"signal 197"}), (198, {_SigNotify,"signal 198"}), (199, {_SigNotify,"signal 199"}), (200, {_SigNotify,"signal 200"}), (201, {_SigNotify,"signal 201"}), (202, {_SigNotify,"signal 202"}), (203, {_SigNotify,"signal 203"}), (204, {_SigNotify,"signal 204"}), (205, {_SigNotify,"signal 205"}), (206, {_SigNotify,"signal 206"}), (207, {_SigNotify,"signal 207"}), (208, {_SigNotify,"signal 208"}), (209, {_SigNotify,"signal 209"}), (210, {_SigNotify,"signal 210"}), (211, {_SigNotify,"signal 211"}), (212, {_SigNotify,"signal 212"}), (213, {_SigNotify,"signal 213"}), (214, {_SigNotify,"signal 214"}), (215, {_SigNotify,"signal 215"}), (216, {_SigNotify,"signal 216"}), (217, {_SigNotify,"signal 217"}), (218, {_SigNotify,"signal 218"}), (219, {_SigNotify,"signal 219"}), (220, {_SigNotify,"signal 220"}), (221, {_SigNotify,"signal 221"}), (222, {_SigNotify,"signal 222"}), (223, {_SigNotify,"signal 223"}), (224, {_SigNotify,"signal 224"}), (225, {_SigNotify,"signal 225"}), (226, {_SigNotify,"signal 226"}), (227, {_SigNotify,"signal 227"}), (228, {_SigNotify,"signal 228"}), (229, {_SigNotify,"signal 229"}), (230, {_SigNotify,"signal 230"}), (231, {_SigNotify,"signal 231"}), (232, {_SigNotify,"signal 232"}), (233, {_SigNotify,"signal 233"}), (234, {_SigNotify,"signal 234"}), (235, {_SigNotify,"signal 235"}), (236, {_SigNotify,"signal 236"}), (237, {_SigNotify,"signal 237"}), (238, {_SigNotify,"signal 238"}), (239, {_SigNotify,"signal 239"}), (240, {_SigNotify,"signal 240"}), (241, {_SigNotify,"signal 241"}), (242, {_SigNotify,"signal 242"}), (243, {_SigNotify,"signal 243"}), (244, {_SigNotify,"signal 244"}), (245, {_SigNotify,"signal 245"}), (246, {_SigNotify,"signal 246"}), (247, {_SigNotify,"signal 247"}), (248, {_SigNotify,"signal 248"}), (249, {_SigNotify,"signal 249"}), (250, {_SigNotify,"signal 250"}), (251, {_SigNotify,"signal 251"}), (252, {_SigNotify,"signal 252"}), (253, {_SigNotify,"signal 253"}), (254, {_SigNotify,"signal 254"}), (255, {_SigNotify,"signal 255"})));
    }
}