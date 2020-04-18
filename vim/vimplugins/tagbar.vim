
"显示类结构tag
Plug 'majutsushi/tagbar'
"按F8即可打开tagbar界面
 nmap <silent> <F8> :TagbarToggle<CR>
 let g:tagbar_ctags_bin = 'ctags' "tagbar以来ctags插件
 let g:tagbar_left = 0 "让tagbar在页面左侧显示1，默认右边0
 let g:tagbar_width = 30 "设置tagbar的宽度为30列，默认40
 let g:tagbar_autofocus = 0 "这是tagbar一打开，光标即在tagbar页面内1，默认0在vim打开的文件内
 let g:tagbar_sort = 0 "设置标签不排序，默认排序
 " move cursor to tagbar
 nmap tg :TagbarOpen fj<cr>
