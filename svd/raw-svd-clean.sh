#!/bin/sh
# A nasty hack to strip out the long lines and carriage returns from stm32F svd's
# Terry Porter 2018 <terry@tjporter.com.au> released under the GPL V2
# 0A = NL ,  0D = CR

PWD=./
# $1 is first argument

dos2unix $1 >/dev/null 2>&1

# strip newlines
tr '\n' ' ' < $1 >/dev/null

sed 's/ \{1,\}/ /g' $1 > $1-1.svd

sed 's/[)(]//g' $1-1.svd > $1-2.svd  # remove ( and )

# gsed ':a;N;s/\n/ /g;ba' $1-2.svd > $1-3.svd
# https://unix.stackexchange.com/questions/114943/can-sed-replace-new-line-characters
sed -z 's/\n/ /g' $1-2.svd > $1-3.svd   # <-- MUCH faster

# replaces newlines
xmllint -format $1-3.svd > build/$1-cleaned.svd

rm $1-1.svd $1-2.svd $1-3.svd
