#!/bin/bash
echo "Printing the releases"
curl -H "Accept: application/vnd.github.v3+json" https://api.github.com/repos/TheJumpCloud/jcapi-powershell/releases | jq '.[] | {tag_name,target_commitish,published_at}'


# echo "The Following Files have been added:"
# git diff HEAD^ 6f3748d672abfdebcefbd69c6451da1ee687a1f3 --compact-summary --diff-filter=A | Grep "generated"
# echo "The Following Files have been modified:"
# git diff HEAD^ 6f3748d672abfdebcefbd69c6451da1ee687a1f3 --compact-summary --diff-filter=M | Grep "generated"
# echo "The Following Files have been deleted:"
# git diff HEAD^ 6f3748d672abfdebcefbd69c6451da1ee687a1f3 --compact-summary --diff-filter=D | Grep "generated"