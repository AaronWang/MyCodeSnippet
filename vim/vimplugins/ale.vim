



"显示语法错误
" Plug 'scrooloose/syntastic'
" set statusline+=%#warningmsg#
" set statusline+=%{SyntasticStatuslineFlag()}
" set statusline+=%*
" let g:syntastic_always_populate_loc_list = 1
" let g:syntastic_auto_loc_list = 1
" let g:syntastic_check_on_open = 1
" let g:syntastic_check_on_wq = 0
"
" 代替 syntastic 语法异步检查
Plug 'dense-analysis/ale'
let g:ale_sign_column_always = 1

"文件内容发生变化时不进行检查
let g:ale_lint_on_text_changed = 'never'
let g:ale_lint_on_insert_leave = 0
"打开文件时不进行检查
let g:ale_lint_on_enter = 0
" chinese in java, will show error
" let g:ale_java_javac_options = '-encoding UTF-8  -J-Duser.language=en'

" Only run linters named in ale_linters settings.
" let g:ale_linters_explicit = 1
"
" let g:ale_linter_aliases = {'vue': ['vue', 'javascript']}
" let g:ale_linters = {'javascript': ['eslint','standard'],'vue':['eslint','vls']}
let g:ale_fixers = {
\   '*': ['remove_trailing_lines', 'trim_whitespace'],
\   'javascript': ['eslint'],
\}
" enalbe airline status extension
let g:airline#extensions#ale#enabled = 1
"
" go to next error
" nmap <silent> <C-k> <Plug>(ale_previous_wrap)
nmap <F2> <Plug>(ale_next_wrap)
nmap <D-CR> :ALEFix<CR>
" let g:ale_sign_error = ">>"
" let g:ale_sign_warning = '--'
" Show 5 lines of errors (default: 10)
let g:ale_list_window_size = 5

"ALE sets some background colors automatically for warnings and errors in the sign gutter,
" highlight clear ALEErrorSign
" highlight clear ALEWarningSign
" let g:ale_completion_delay = 500
" let g:ale_echo_delay = 20
" let g:ale_lint_delay = 500
" let g:ale_echo_msg_format = '[%linter%] %code: %%s'
" let g:ale_lint_on_text_changed = 'normal'
" let g:ale_lint_on_insert_leave = 1
" let g:ale_c_gcc_options = '-Wall -O2 -std=c99'
" let g:ale_cpp_gcc_options = '-Wall -O2 -std=c++14'
" let g:ale_c_cppcheck_options = ''
" let g:ale_cpp_cppcheck_options = ''
" hi! clear SpellBad
" hi! clear SpellCap
" hi! clear SpellRare
" hi! SpellBad gui=undercurl guisp=red
" hi! SpellCap gui=undercurl guisp=blue
" hi! SpellRare gui=undercurl guisp=magenta
"
