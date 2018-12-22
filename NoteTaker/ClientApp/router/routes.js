import NoteTaker from 'components/note-taker'

export const routes = [
  { name: 'note-taker', path: '/', component: NoteTaker, display: 'NoteTaker', icon: 'graduation-cap' },
  { name: 'note-taker', path: '/:id', component: NoteTaker, display: 'NoteTaker', icon: 'graduation-cap' },
]
