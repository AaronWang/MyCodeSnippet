
" On-demand loading
" Plug 'scrooloose/nerdtree', { 'on':  'NERDTreeToggle' }
" Plug 'scrooloose/nerdtree'
Plug 'xuyuanp/nerdtree-git-plugin'
Plug 'preservim/nerdtree'
let NERDTreeShowHidden=1
" auto open nerdtree, no need <F3>
" share nerdtree between tabs
" map <F3> :NERDTreeMirror<CR>
map <F3> :NERDTreeToggle<CR>
" map <F4> :NERDTreeFind<CR>
" map <F3> :NERDTreeFocus<CR>
"
"auto move nerdtree to current tab
" returns true if is NERDTree open/active

function! s:isNTOpen()
  return  exists("t:NERDTreeBufName") && (bufwinnr(t:NERDTreeBufName) != -1)
endfunction

" if don't do counting, <F3> will start two windows with different root
" directory, the reason may cause by nerdtree initialization
" 我自己定义的
let g:nerdTreeCount = 0

function! s:syncTreeRoot()
    let t:result = exists("t:NERDTreeBufName") && (bufwinnr(t:NERDTreeBufName) != -1)
    if( &modifiable && t:result && strlen(expand('%')) > 2 && g:nerdTreeCount >2)
        let t:nerdTreeRoot = g:NERDTree.ForCurrentTab().getRoot().path.str()
        " echom "current nerdtreeroot : ".t:nerdTreeRoot."  current vim cwd : ".getcwd()
      "key nerdtree root same with vim  pwd
        if( t:nerdTreeRoot != getcwd())
            NERDTreeCWD
            wincmd p
        endif
        "-----------------
        "
       if s:isInProjectPWD()
            NERDTreeFind
            wincmd p
       endif
    endif
    if(t:result && strlen(expand('%')) > 8 && g:nerdTreeCount<10)
        let g:nerdTreeCount+=1
    endif
endfunction

function! s:isInProjectPWD()
    " echom 'filepath:'.expand('%:p:h')
    " echom 'project directory :'.getcwd()
    return stridx(expand('%:p:h'),getcwd()) != -1
endfunction

" calls NERDTreeFind if NERDTree is active, current window contains a modifiable file, and we're not in vimdiff
function! s:syncTree()
            " call s:isNTOpen()
            " &modifiable
 " if s:isNTOpen() && strlen(expand('%')) > 0 && !&diff && s:isInProjectPWD()
  "   NERDTreeFind
  "   wincmd p
  " endif
endfunction

augroup nerdtreeAuto
    au!
    autocmd BufEnter * call s:syncTreeRoot()

    " autocmd BufEnter * call s:syncTree()
augroup end

" autocmd BufEnter * if s:isNTOpen() && &modifiable && bufname('%') !~# 'NERD_tree_'| cd %:p:h | NERDTreeCWD| wincmd p | endif
" echom getcwd()
"
" autocmd BufEnter * if s:isNTOpen() && &modifiable && bufname('%') !~# 'NERD_tree_' | endif
"
"back to nerdtree
"
nmap nt :NERDTreeFocus<cr>
