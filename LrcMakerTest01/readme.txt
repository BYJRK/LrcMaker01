﻿这个版本为测试版v1.0.0，欢迎试用！

目前尚存BUG正在逐步修复中......

在使用过程中可能遇到的问题：

Q：“打开歌词文件”发现内容是乱码？
A：在中文系统中，使用的文字编码格式通常为GB2312（在记事本中，保存选项的“ANSI”在中文系统即为GB2312）。但是，记事本文件有可能编码格式为其他（尤其是utf-8），导致导入的歌词出现乱码情况。
针对这一情况，可以：
方法一 另存为歌词文件，编码选择ANSI
方法二 复制歌词文件，然后使用“来自剪贴板”功能

Q：点击“插入项”后，为什么下方显示的当前时间和左边的当前时间有一个小的偏差？
A：本软件所使用的播放器是Windows Media Player。由于其工作原理，在pause事件后，歌曲并不能够立刻停止，所以导致左边的当前时间会稍快于下方的当前时间。实际的暂停点以下方为准。

Q：为什么打开歌曲后，总时长在播放前都不会显示？
A：由于播放器的工作原理，在开始播放前，文件流并没有被加载，所以无法立刻显示。