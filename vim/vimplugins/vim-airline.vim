"
"airline 状态栏加强插件
Plug 'vim-airline/vim-airline'
" Plug 'vim-airline/vim-airline-themes'
let g:airline#extensions#tabline#enabled = 1
" let g:airline#extensions#tabline#left_sep = ' '
" let g:airline#extensions#tabline#left_alt_sep = '|'
let g:airline#extensions#tabline#formatter = 'default'
let g:airline_powerline_fonts = 1
let g:airline_highlighting_cache = 1

  let g:airline_theme_patch_func = 'AirlineThemePatch'
  function! AirlineThemePatch(palette)
    if g:airline_theme == 'dark'
      for colors in values(a:palette.inactive)
       let colors[3] = 245
      endfor
    endif
  endfunction
