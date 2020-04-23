

"文件查找,可以被leaderF，fzf替换
" Plug 'kien/ctrlp.vim'
"
" tag/search plugin LeaderF,can replace tagbar, ctrlP,fzf
Plug 'Yggdroot/LeaderF', { 'do': './install.sh' }
let g:Lf_WindowPosition = 'popup'
let g:Lf_PreviewInPopup = 1
" let g:Lf_StlSeparator = { 'left': "\ue0b0", 'right': "\ue0b2", 'font': "DejaVu Sans Mono for Powerline" }
" nmap tg :LeaderfFunction!<cr>
let g:Lf_ShortcutF = '<c-p>'
" let g:Lf_ShortcutB = '<d-n>'
" noremap <c-n> :LeaderfMru<cr>
" noremap <d-p> :LeaderfFunction!<cr>
" noremap <d-n> :LeaderfBuffer<cr>
" noremap <d-m> :LeaderfTag<cr>
"
" For GUI vim, the icon font can be specify like this, for example
" let g:Lf_DevIconsFont = "DejaVuSansMono Nerd Font Mono"
let g:Lf_DevIconsFont = "Hack\ Nerd\ Font"
" If needs

" let g:Lf_StlSeparator = { 'left': '', 'right': '', 'font': '' }
let g:Lf_RootMarkers = ['.project', '.root', '.svn', '.git']
" let g:Lf_WorkingDirectoryMode = 'Ac'
" let g:Lf_WindowHeight = 0.20
let g:Lf_CacheDirectory = expand('~/.vim/cache')
" let g:Lf_ShowRelativePath = 0
" let g:Lf_HideHelp = 1
" let g:Lf_StlColorscheme = 'powerline'
" let g:Lf_PreviewResult = {'Function':0, 'BufTag':0}
"
" 这里定义了 CTRL+P 在当前项目目录打开文件搜索，CTRL+N 打开 MRU搜索，搜索你最近打开的文件，这两项是我用的最频繁的功能。接着 ALT+P 打开函数搜索，ALT+N 打开 Buffer 搜索：
"
